using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions_Predicate_Delegates_Andre_a
{
    class Program
    {
        //Feels
        private static string _searchCriteria;
        public static List<Car> _carCatalog = new List<Car>();
        public static string _userInput;


        //Main
        static void Main(string[] args)
        {
            //Private Feels
            bool _loop = true;
            bool _firstTime = true;
            
            //Adds cars
            if (_firstTime == true)
            {


                Car car1 = new Car("fiat", 1999);
                Car car2 = new Car("Volvo", 2003);
                Car car3 = new Car("Audi", 2006);

                _carCatalog.Add(car1);
                _carCatalog.Add(car2);
                _carCatalog.Add(car3);

                _firstTime = false;
            }
            

            //MainLoop
            while (_loop == true)
            {
                Console.WriteLine("Hello Car World! See car model press ( A )");


                _userInput = Console.ReadLine();
                if (_userInput == "A") { 
                                        Console.WriteLine("What model");
                                        _searchCriteria = Console.ReadLine();

                    try
                    {
                        Predicate<Car> myPredicateDeligate = new Predicate<Car>(CarModelSearch);
                        Car searchResult = _carCatalog.Find(myPredicateDeligate);
                        //if (myPredicateDeligate )
                        //{
                        //    Console.WriteLine("No mach with model");
                        //}
                        Console.WriteLine(searchResult);
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("No mach with model");

                    }
                }



                Console.ReadKey();
                _loop = false;
            }
        }


        //Metods 
        static bool CarModelSearch(Car car)
        {
            return car._type.Equals(_searchCriteria);
        }


    }
}
