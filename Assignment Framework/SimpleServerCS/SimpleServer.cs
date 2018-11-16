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

        public SimpleServer(bool UseLoopback, int port)
        {
            IPAddress ipAddress = UseLoopback ? IPAddress.Loopback : LocalIPAddress();
            _tcpListener = new TcpListener(ipAddress, port);
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
                    Client a = new Client(socket);
                    _clients.Add(a);
                    a.Start();
                }
            }
            
        }

        public void Stop()
        {
            _tcpListener.Stop();
        }

        public static void SocketMethod(Client socket)
        {
            Socket client = socket.Socket;

            try
            {
                string receivedMessage;
                
                NetworkStream stream = new NetworkStream(client, true);
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

                writer.WriteLine("Send 0 for available options");
                writer.Flush();

                while ((receivedMessage = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received...");

                    int i;

                    if (Int32.TryParse(receivedMessage, out i))
                    {
                        //writer.Write(GetReturnMessage(i));
                    }
                    else
                    {
                        //writer.Write(GetReturnMessage(-1));
                    }

                    writer.Flush();

                    if (i == 9)
                        break;
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

        private string GetReturnMessage(int code)
        {
            string returnMessage;

            switch (code)
            {
                case 0:
                    returnMessage = "Send 1, 3, 5 or 7 for a joke. Send 9 to close the connection.";
                    break;
                case 1:
                    returnMessage = "What dog can jump higher than a building? Send 2 for punchline!";
                    break;
                case 2:
                    returnMessage = "Any dog, buildings can't jump!";
                    break;
                case 3:
                    returnMessage = "When do Ducks wake up? Send 4 for punchline!";
                    break;
                case 4:
                    returnMessage = "At the Quack of Dawn!";
                    break;
                case 5:
                    returnMessage = "How do cows do mathematics? Send 6 for punchline!";
                    break;
                case 6:
                    returnMessage = "They use a cow-culator.";
                    break;
                case 7:
                    returnMessage = "How many programmers does it take to screw in a light bulb? Send 8 for punchline!";
                    break;
                case 8:
                    returnMessage = "None, that's a hardware problem.";
                    break;
                case 9:
                    returnMessage = "Bye!";
                    break;
                default:
                    returnMessage = "Invalid Selection";
                    break;
            }

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
