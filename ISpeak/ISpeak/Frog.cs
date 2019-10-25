using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Frog : ISpeak
    {
        public Frog()
        {

        }

        public string Speak()
        {
            return ("Hippety Hoppety, abolish private property");
        }
    }
}
