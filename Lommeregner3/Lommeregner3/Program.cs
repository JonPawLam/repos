using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface
            string stjerne=("************************************************");
            Console.WriteLine(stjerne + stjerne);
            Console.WriteLine("          +               -            Lommeregner              *              /");
            Console.WriteLine("Vælg første tal, tryk enter      vælg imellem + - * /, tryk enter    Vælg andet tal, tryk enter      ");
            Console.WriteLine(stjerne + stjerne);

            //math
            int Tal1;
            int Tal2;
            int udregning=0;
            string mellemstykke;
            bool mellemLoop = true;

            //Div
            string plus = "+";
            string minus = "-";
            string gange = "*";
            string divider = "/";

            
            bool pluseTrue = false;
            bool minusTrue = false;
            bool gangeTrue = false;
            bool dividerTrue = false;

            //tal 1
            while (!int.TryParse(Console.ReadLine(), out Tal1))
            {
                Console.WriteLine("Vælg helt tal");
            }


            //Mellemstykke
            while (mellemLoop == true) 
            {
                mellemstykke = Console.ReadLine();
                if (mellemstykke == plus)
                {
                    mellemLoop = false;

                    pluseTrue = true;
                    minusTrue = false;
                    gangeTrue = false;
                    dividerTrue = false;
                }
                else if(mellemstykke == minus)
                {
                    mellemLoop = false;

                    pluseTrue = false;
                    minusTrue = true;
                    gangeTrue = false;
                    dividerTrue = false;
                }
                else if (mellemstykke == gange)
                {
                    mellemLoop = false;

                    pluseTrue = false;
                    minusTrue = false;
                    gangeTrue = true;
                    dividerTrue = false;
                }
                else if (mellemstykke == divider)
                {
                    mellemLoop = false;

                    pluseTrue = false;
                    minusTrue = false;
                    gangeTrue = false;
                    dividerTrue = true;
                }
                else
                {
                    mellemLoop = true;
                    Console.WriteLine("Vælg imellem + - * /");
                }

                while (!int.TryParse(Console.ReadLine(), out Tal2))
                {
                    Console.WriteLine("Vælg helt tal");
                }

                // udregning

                if (pluseTrue == true)
                {
                    udregning = (Tal1 + Tal2);
                }
                if (minusTrue == true)
                {
                    udregning = (Tal1 - Tal2);
                }
                if (gangeTrue == true)
                {
                    udregning = (Tal1 * Tal2);
                }
                if (dividerTrue == true)
                {
                    udregning = (Tal1 / Tal2);
                }

                Console.WriteLine(stjerne + stjerne);
                Console.Write(udregning);
                Console.WriteLine();
                Console.WriteLine(stjerne + stjerne);

            }


            Console.ReadKey();



        }
    }
}
