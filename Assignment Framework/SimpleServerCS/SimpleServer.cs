using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Shared;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleServerCS
{
    class SimpleServer
    {
        TcpListener _tcpListener;
        private Object thisLock = new Object();
        static List<Client> _clients = new List<Client>();
        private BinaryFormatter _BinaryFormatter;

        public SimpleServer(string ipAddress, int port)
        {
            IPAddress ip = IPAddress.Parse(ipAddress);
            _tcpListener = new TcpListener(ip, port);
        }

        public void Start()
        {
            _tcpListener.Start();
            
            Console.WriteLine("Listening...");
            lock(thisLock)
            {
                while(true)
                {
                    Socket socket = _tcpListener.AcceptSocket();
                    Console.WriteLine("Connection Made");
                    Client newClient = new Client(socket);
                    _clients.Add(newClient);
                    newClient.Start();
                }
            }
        }

        public void Stop()
        {
            _tcpListener.Stop();
        }

        public static void SocketMethod(Client client)
        {
            Socket socket = client._Socket;

            try
            {
                int noOfIncomingBytes;
                while ((noOfIncomingBytes = client._Reader.ReadInt32()) != 0)
                {
                    byte[] bytes = client._Reader.ReadBytes(noOfIncomingBytes);
                    BinaryFormatter bf = new BinaryFormatter();
                    MemoryStream memoryStream = new MemoryStream(bytes);
                    Packet packet = bf.Deserialize(memoryStream) as Packet;

                    switch (packet.type)
                    {
                        case PacketType.EMPTY:
                            foreach (Client c in _clients)
                            {
                                c.Send(packet);
                            }
                            break;
                        case PacketType.NICKNAME:
                            foreach (Client c in _clients)
                            {
                                c.Send(packet);
                            }
                            break;
                        case PacketType.CHATMESSAGE:
                            foreach (Client c in _clients)
                            {
                                c.Send(packet);
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private string GetReturnMessage(Packet packet)
        {
            string returnMessage = "";

            return returnMessage;
        }

        private IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .LastOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

    }
}
