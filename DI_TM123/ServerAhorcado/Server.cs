using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerAhorcado
{
    internal class Server
    {
        public int Port;
        public Socket socket;
        public bool IsRunning = true;
        public void init()
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, Port);
            using (socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    socket.Bind(iPEndPoint);
                    socket.Listen(1);
                    while (IsRunning)
                    {
                        Thread thread = new Thread(() =>
                        {
                            // TODO pasar funcion de client manager
                        });
                        thread.Start();
                    }
                }
                catch (SocketException)
                {
                }
            }
        }
    }
}
