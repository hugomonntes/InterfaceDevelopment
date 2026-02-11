using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DI_EX4_T5
{
    internal class Server
    {
        public int Port { get; set; }
        public bool ServerIsRunning { get; set; } = false;
        public Socket socket;
        public void Init()
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, Port);
            using (socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    socket.Bind(iPEndPoint);
                    socket.Listen(10);
                    ServerIsRunning = true;
                    while (ServerIsRunning)
                    {
                        Thread thread = new Thread(() => { });
                        thread.Start();
                    }
                }
                catch (SocketException)
                {
                }
            }
        }

        public int getFreePort(int initialPort)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, initialPort);
            using (socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                bool isFree = false;
                do
                {
                    try
                    {
                        socket.Bind(iPEndPoint);
                        socket.Listen(10);
                        isFree = true;
                    }
                    catch(SocketException)
                    {
                        initialPort++;
                    }
                }
                while (isFree);
            }
            return initialPort;
        }
    }
}
