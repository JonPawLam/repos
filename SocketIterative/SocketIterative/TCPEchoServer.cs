using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SocketIterative
{
    class TCPEchoServer
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("169.254.160.194");
            TcpListener serverSocket = new TcpListener(ip, 6789);
            serverSocket.Start();

            Console.WriteLine("server Started");
            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Server Activated");
                EchnoService echnoService = new EchnoService(connectionSocket);
                echnoService.doIt();
            }

            //ns.Close();
            //connectionSocket.Close();
            //serverSocket.Stop();
            
        }
    }
}
