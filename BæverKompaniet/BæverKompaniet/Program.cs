using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BæverKompaniet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Bruger input
            bool _loop = true;
            string _brugerInput;


            //Lejligheds liste og skabelse af standart lejligheder
            List<Lejligheder> lejlighedslList = new List<Lejligheder>();
            Lejligheder lejlighed1 = new Lejligheder("1", 4000,90,2);
            Lejligheder lejlighed2 = new Lejligheder("2", 6000, 120, 4);
            lejlighedslList.Add(lejlighed1);
            lejlighedslList.Add(lejlighed2);


            //Loop For program

            while (_loop== true)
            {
                Console.WriteLine("For at tilføje lejligheder tryk: 1           For se lejligheder tryk: 2           Afslut tryk: 3.");
                _brugerInput = (Console.ReadLine());

                if (_brugerInput == "1")
                {
                    Console.Clear();
                    string _bruger1;
                    double _bruger2;
                    int _bruger3;
                    double _bruger4;

                    Console.WriteLine("Vælg lejlighed navn");
                    _bruger1 = Console.ReadLine();
                    Console.WriteLine("Pris");
                    _bruger2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("størrelse i kvm");
                    _bruger3 = Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Rum");
                    _bruger4 = Convert.ToDouble( Console. ReadLine());


                    Lejligheder lejligheder = new Lejligheder(_bruger1,_bruger2,_bruger3,_bruger4);
                    lejlighedslList.Add(lejligheder);
                    Console.Clear();
                }


                else if (_brugerInput == "2")
                {
                    Console.Clear();
                    foreach (var lejlighed in lejlighedslList)
                    {
                        Console.WriteLine(lejlighed);

                    }
                }

                else if (_brugerInput == "3")
                {
                    _loop = false;
                }

                else
                {
                    Console.WriteLine("Fejl vælg mellem 1 2 eller 3");
                }
                
            }
           
        }
    }
}
