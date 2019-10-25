using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Philosopher : ISpeak
    {

        public Philosopher()
        {
            
        }

        public string Speak()
        {
            return ("Efter utalige timer, søligbat i 32 år. Har jeg enelig kommet i komplet zen. Med disse evner vil jeg nu lytte på dyr");
        }

        public string Think()
        {
            return("Dette kan kun gå galt");
        }

    }
}
