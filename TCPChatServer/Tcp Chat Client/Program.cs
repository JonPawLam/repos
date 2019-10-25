using System;
using System.IO;
using System.Net.Sockets;

namespace Tcp_Chat_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n" + "                         Sad, Sad, Mad, Chat!\n" + "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            
            TcpClient clientSocket = new TcpClient("localhost", 6789);
            Console.WriteLine("                         Client Start\n");

            while (true)
            {
                //get Stream
                Stream ns = clientSocket.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                StreamReader sr = new StreamReader(ns);
                sw.AutoFlush = true; // sikre forced buffer writing
                
                //Skriv
                string message = Console.ReadLine();
                sw.WriteLine(message);

                //Læs
                String message2 = sr.ReadLine();
                Console.WriteLine("Other Sad person said: " + message2);

            }
        }
    }
}
