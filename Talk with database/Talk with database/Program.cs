using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talk_with_database
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            using (var db = new CostumerContext())
            {
                var query = from hotel in db.Hotel
                    select hotel;


                foreach (var hotel in query)
                {
                    Console.WriteLine(hotel);
                }



            }




            Console.WriteLine("Hello World!");
            Console.ReadKey();

            

        }

        public void myNewProgram()
        {




        }


    }
}
