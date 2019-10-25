using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();

        }
    }
}
