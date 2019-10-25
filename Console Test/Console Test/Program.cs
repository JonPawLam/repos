using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true) { 
            String Letters;
            Console.WriteLine("******************************");
            Console.WriteLine("       Simple Word");
            Letters = Convert.ToString(Console.ReadKey());
            
            Console.WriteLine(Letters);
            }
        }
    }
}
