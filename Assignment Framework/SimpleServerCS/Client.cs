using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using Shared;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleServerCS
{
    class Client
    {
        public Socket _Socket;
        private Thread _Thread;

        private NetworkStream _Stream;
        private BinaryReader _Reader;
        private BinaryWriter _Writer;
        private BinaryFormatter _Formatter;

        public Client(Socket socket)
        {
            _Socket = socket;

            _Stream = new NetworkStream(socket, true);
            _Reader = new BinaryReader(_Stream, Encoding.UTF8);
            _Writer = new BinaryWriter(_Stream, Encoding.UTF8);
        }

        public void Start()
        {
            _Thread = new Thread(new ThreadStart(SocketMethod));
            _Thread.Start();
        }

        public void SocketMethod()
        {
            SimpleServer.SocketMethod(this);
        }

        public void Close()
        {
            _Socket.Close();
            if (_Thread.IsAlive)
            {
                _Thread.Abort();
            }
        }

        public void Send(Packet data)
        {
            MemoryStream mem = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(mem, data);
            byte[] buffer = mem.GetBuffer();

            _Writer.Write(buffer.Length);
            _Writer.Write(buffer);
            _Writer.Flush();
        }
    }
}
