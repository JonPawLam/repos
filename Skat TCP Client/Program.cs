using System;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace Skat_TCP_Client
{
    class Program
    {
        public static string CarType;
        public static int CarPris;

        public static bool CarTypeLoop;
        public static bool CarTypeLoop2=true;
        public static string consoleUIString = "------------------------------------------------------------------";

        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";

        static void Main(string[] args)
        {

                //---UI---

                Console.WriteLine(consoleUIString);
                Console.WriteLine("                         Skat Bil Afgift system");
                Console.WriteLine(consoleUIString);

                #region CarType

                //Client vælger mellem bil type
                Console.WriteLine("Bil Type Personbil = A");
                Console.WriteLine("Bil Type Elbil = B");

                CarTypeLoop = true;
                while (CarTypeLoop == true)
                {
                    CarType = Console.ReadLine();
                    if (!(CarType == "A" || CarType == "B"))
                    {
                        Console.WriteLine("vælg mellem A Eller B");
                    }
                    else
                    {
                        CarTypeLoop = false;
                    }
                }

                #endregion

                #region CarPrice

                //Client Sender Pris af bilen
                Console.WriteLine("Hvad er Prisen?");
                while (CarPris == 0 || CarPris < 0)
                {
                    try
                    {
                        CarPris = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fejl I Prisen");

                    }
                }

                #endregion

                //---Opretter en TCPClient & stream på ønskede IP and port no.---
                TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                NetworkStream nwStream = client.GetStream();
                byte[] typeBilBytesToSend = ASCIIEncoding.ASCII.GetBytes(CarType + CarPris);

                //---   viser hvilken bil & pris vi har sent, og udsender streamen    ---
                Console.WriteLine("Sending Bil Type: " + CarType + " Med Prisen: " + CarPris);
                nwStream.Write(typeBilBytesToSend, 0, typeBilBytesToSend.Length);

                //---   aflæser hvad prisen er og printer den ud til consolen   ---
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                Console.WriteLine(consoleUIString);
                Console.WriteLine("Bilafgiften er: " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead) + "KR.");
                Console.WriteLine(consoleUIString);
                Console.ReadLine();


                client.Close();
              
            
        }
    }
}
