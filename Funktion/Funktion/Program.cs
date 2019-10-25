using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktion
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1;
            int tal2;

            tal1 = Convert.ToInt32(Console.ReadLine());
            tal2 = Convert.ToInt32(Console.ReadLine());
            int isbiggest = svar1(tal1, tal2);
            
            if (isbiggest==0)
            {
                Console.WriteLine("tal 1 er størst");
            }

            else if (isbiggest == 1)
            {
                Console.WriteLine("tal 1 er størst");
            }
            else
            {
                Console.WriteLine("tallene er lige store");
            }
            Console.ReadLine();
        }
        
        public static int svar1(int tal1, int tal2)
        {
            if (tal1 > tal2) return 0;
            //if (tal1 < tal2) return 1;
            else return 2;

        }

    }
}
