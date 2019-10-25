using System;
using System.Data.SqlTypes;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace TCPChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Åbner en lytter efter Tcp Request
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n" + "                         Sad, Sad, Mad, Chat!\n" + "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //TcpListener serverSocket = new TcpListener(6789);

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ip,6789);

            Console.WriteLine("                         Server Start");

            //Starter serveren Socket
            serverSocket.Start();

            //Server activated
            Console.WriteLine("                         Server activated\n");

            while (true)
            {


            //Verification
            TcpClient connectionSocket = serverSocket.AcceptTcpClient();


            
            //Starter en Stream
            Stream ns = connectionSocket.GetStream();

            // Using Byte Array
            //string str = (Console.ReadLine());
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;


                //Læs
                String message = sr.ReadLine();
                Console.WriteLine("Other Sad person said: " + message);

                //Skriv
                string message2 = Console.ReadLine();
                sw.WriteLine(message2);

            }
        }
    }
}
