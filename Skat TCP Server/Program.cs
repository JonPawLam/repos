using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Skat_TCP_Server
{
    class Program
    {
        //Vælger port og IP
        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";

        static void Main(string[] args)
        {
            //---Lytter efter Client---
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO);
            Console.WriteLine("Venter på client");
            listener.Start();

            //WhileLoop så serveren kan modtage flere klienter.

            while (true)
            {
            
            //---acceptere clienten---
            TcpClient client = listener.AcceptTcpClient();

            //---Modtager date / modtager bilen---
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

            //---Conventere dataen til string + UI---
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received : " + dataReceived);

            //---Udregner dataReceived, tager første del som bruges til biltype og resten som pris.
                string carType = Convert.ToString(dataReceived[0]);
                double carPris = Convert.ToDouble(dataReceived.Substring(1));

                if (carType == "A")
                {
                    carType = "PersonBil";
                }
                else
                    carType = "Elbil";
                

                //---Udarbejder data fra Client via Skat Library
            
                double udregnedePris = (Skat.Afgift.BilAfgift(carPris, carType));
                
                //---write back the text to the client---
           
                Console.WriteLine("Sending back : " + udregnedePris);

                //konventere, sender, & afslutter kunden

                string udregnedePrisConvert = Convert.ToString(udregnedePris);
                byte[] typeBilBytesToSend = ASCIIEncoding.ASCII.GetBytes(udregnedePrisConvert);
                nwStream.Write(typeBilBytesToSend, 0, typeBilBytesToSend.Length);
                
                nwStream.Write(buffer, 0, bytesRead);
                client.Close();
            }
       }

    }
    
}
