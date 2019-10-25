using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Loop = true;
            while (Loop == true)
            {
                //interface og tekst
                string stjerner = "***********************************************";

                //Mat
                int tal1Efter;

                bool Tjek=true;
                string mellemStykke;
                int tal2Efter;

                bool plus = false;
                bool minus = false;
                bool gange= false;
                bool divideret = false;

                string plusTegn="+";
                string minusTegn="-";
                string gangeTegn="*";
                string divideretTegn="/";



                //Interface start
                Console.WriteLine(stjerner+stjerner);
                Console.WriteLine("           +           -           Bootleg lommeregner         *           /           ");
                Console.WriteLine("Skriv første tal tryk enter     vælg imellem + - * / tryk enter    vælg andet tal tryk enter     ");   
                Console.WriteLine(stjerner + stjerner);

                while (!int.TryParse(Console.ReadLine(), out tal1Efter))
                {
                    Console.WriteLine("Vælg helt tal");
                }

                while (Tjek == true)
                {
                    mellemStykke = Convert.ToString (Console.ReadLine());
                    if (mellemStykke == plusTegn)
                    {
                        plus = true;
                        minus = false;
                        gange = false;
                        divideret = false;
                        Tjek = false;
                        break;
                    }

                    else if (mellemStykke == minusTegn)
                    {
                        plus = false;
                        minus = true;
                        gange = false;
                        divideret = false;
                        Tjek = false;
                        break;
                    }

                    else if (mellemStykke == gangeTegn)
                    {
                        plus = false;
                        minus = false;
                        gange = true;
                        divideret = false;
                        Tjek = false;
                        break;
                    }

                    else if (mellemStykke == divideretTegn)
                    {
                        plus = false;
                        minus = false;
                        gange = false;
                        divideret = true;
                        Tjek = false;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("vælg imellem + - * /");
                        Tjek = true;
                    }

                }
                
                while (!int.TryParse(Console.ReadLine(), out tal2Efter))
                {
                    Console.WriteLine("Vælg helt tal");
                }

                Console.WriteLine(stjerner + stjerner);





                if (plus == true)
                {
                    Console.WriteLine(tal1Efter + tal2Efter);
                }
                
                else if (minus == true)
                {
                    Console.WriteLine(tal1Efter - tal2Efter);
                }

                else if (gange == true)
                {
                    Console.WriteLine(tal1Efter * tal2Efter);
                }

                else if (divideret == true)
                {
                    Console.WriteLine(tal1Efter / tal2Efter);
                }


                Console.WriteLine(stjerner + stjerner);


                Console.ReadLine();


                Console.Clear();
                
                //Code for the While loops: https://social.msdn.microsoft.com/Forums/en-US/4072e3b3-6046-4927-b58c-c6c3dfd12220/how-to-properly-validate-user-input-in-c-loop-vs-trycatch?forum=csharpgeneral
            }

            
        }
    }
}
