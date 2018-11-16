using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleServerCS
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleServer _simpleServer = new SimpleServer(true, 4444);

            _simpleServer.Start();

            _simpleServer.Stop();
        }
    }
}
