using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Dog : ISpeak
    {
        public Dog()
        {
            
        }

        public string Speak()
        {
            return ("Wufety Dufety, Starlin Community");
        }
    }
}
