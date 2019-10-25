using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightControler
{
    class FlightConsole
    {
        public void MyCode()
        {
            Plane planeA = new Plane(1, 1, 1, 1, "MamboNR1");

            Console.WriteLine($"Flight plane:, {planeA.FlyID}");
            Console.WriteLine($"X kord: {planeA.Xkordinat}");
            Console.WriteLine($"Y kord: { planeA.Ykordinat}");
            Console.WriteLine($"X speed: { planeA.XSpeed}");
            Console.WriteLine($"Y speed: { planeA.YSpeed}");
            Console.ReadKey();

            
        }
    }
}
