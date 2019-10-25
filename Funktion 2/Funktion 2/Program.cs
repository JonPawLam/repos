using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());

             int hvadErStørst = StørelseTjek( tal1, tal2);
            Console.WriteLine(hvadErStørst);
        }
        
        static public int StørelseTjek(int tal1, int tal2)
        {
            if (tal1 < tal2) return 0;
            
        }
    }
}
