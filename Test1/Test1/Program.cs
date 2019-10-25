using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int loop=1; loop<2; )
            {
            string Stjerner = ("*****************************************************");
            
            int number1;
            string mellemstykke;
            int number2;
            int total= 0;

            //rengøring
            Console.Clear();
            Console.WriteLine(Stjerner+Stjerner);
            Console.WriteLine("             +             -             Bootleg lommeregner             *             / ");
            Console.WriteLine(Stjerner+Stjerner);
            Console.WriteLine("Vælg første tal afslut med enter, vælg imellem + - * / afslut med enter, vælg sidste tal, afslut med enter");
            Console.WriteLine(Stjerner+Stjerner);
            
                
                //Givede tal 1

                try
                {
                    number1 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vælg et helt tal");
                    number1 = int.Parse(Console.ReadLine());
                }


                try
                {
                    mellemstykke = (Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vælg I mellem +, -, *, /");
                    mellemstykke = (Console.ReadLine());
                }

                


                // Givede tal 2
                try
                {
                    number2 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vælg et helt tal");
                    number2 = int.Parse(Console.ReadLine());
                }




                if (mellemstykke == ("+"))
            {
                total = (number1 + number2);
            }

            else if (mellemstykke == ("-"))
            {
                total = (number1 - number2);
            }

            else if (mellemstykke == ("*"))
            {
                total = (number1 * number2);
            }

            else if (mellemstykke == ("/"))
            {
                total = (number1 / number2);
            }
                Console.WriteLine(Stjerner + Stjerner);
                Console.WriteLine(total);
                Console.WriteLine(Stjerner + Stjerner);
                Console.ReadKey();




            }
            
        }
    }
}
