using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SocketIterative
{
    class EchnoService
    {
        
        public  TcpClient Connection { get; set;}

        public EchnoService(TcpClient connection)
        {
            connection = Connection;
        }

        public void doIt()
        {

            Stream networkstream = Connection.GetStream();
            StreamReader sr = new StreamReader(networkstream);
            StreamWriter sw = new StreamWriter(networkstream);
            sw.AutoFlush = true; // enable automatic flushing

            string message = sr.ReadLine();
            string answer = "";
            
            while (message != null && message != "")
            {
                Console.WriteLine("Client: " + message);
                answer = message.ToUpper();
                sw.WriteLine(answer);
                message = sr.ReadLine();
            }
        }
    }
}