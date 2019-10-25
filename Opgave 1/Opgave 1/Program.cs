using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Et program som kan tage 2 tal, se om det er positiv, negativ eller nul. Og sammeligne dem");
            Console.WriteLine("Vælg første tal & andet tal");
            
            double tal1;
            double tal2;
            bool loop=true;

                //Tal Valg og bruger tjek
                #region

            string stjerne = ("***********************************");
            string space = ("                                     ");
                while (loop == true)
                {

                
                Console.WriteLine(stjerne + stjerne + stjerne);

                //tal 1

                while ( !Double.TryParse(Console.ReadLine(), out tal1))
                {
                    Console.WriteLine("Vælg et tal");
                }
                //Vælg Tal 2

                while (!Double.TryParse(Console.ReadLine(), out tal2))
                {
                    Console.WriteLine("Vælg et andet tal");
                }

                
                    Console.WriteLine(stjerne + stjerne + stjerne);

                #endregion
                
                //Tal 1 Tjek
                #region
                if (tal1 >= 0.0 && tal1 != 0)
                    {
                        Console.WriteLine("Tal 1 er mere en 0" + space + "Tal 1 er: " + tal1);
                    }
                    if (tal1 <= 0.0 && tal1 != 0)
                    {
                        Console.WriteLine("Tal 1 mindre en 0");
                        Console.WriteLine("Tal 1 er: " + space + "Tal 1 er: " + tal1);

                    }
                    if (tal1 == 0.0)
                    {
                        Console.WriteLine("Tal 1 tallet 0");
                        Console.WriteLine("Tal 1 er:" + space + "Tal 1 er: " + tal1);
                    }
                #endregion

                //Tal 2 Tjek
                #region
                if (tal2 >= 0.0 && tal2 != 0)
                    {
                        Console.WriteLine("Tal 2 er mere en 0"+ space + "Tal 2 er: " + tal2);
                    }
                    if (tal2 <= 0.0 && tal1 != 0)
                    {
                        Console.WriteLine("Tal 2 mindre en 0" +space + "Tal 2 er: " + tal2);

                    }
                    if (tal2 == 0.0)
                    {
                        Console.WriteLine("Tal 2 tallet 0" +space+ "Tal 2 er: " + tal2);
                    }
                #endregion

                //Diff
                #region
                double diff = tal1+tal2;    

                            if (tal1<=tal2)
                            {
                                Console.WriteLine("tal 1 er støre med en diff på: " + diff);

                            }

                            if (tal1 >= tal2)
                            {
                                Console.WriteLine("tal 2 er støre med en diff på: " + diff);
                            }
                #endregion
            }

            Console.ReadKey();
        }
    }
}
