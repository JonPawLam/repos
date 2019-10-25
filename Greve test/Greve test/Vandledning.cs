using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greve_test
{
    class Vandledning
    {
        public string _vejKode;
        public int _dimention;
        public string _type;
        public int _aarstal;
        public int _længe;


        public Vandledning(string vejKode, int dimention, string type, int aarstal, int længe)
        {
            _vejKode = vejKode;
            _dimention = dimention;
            _type = type;
            _aarstal = aarstal;
            _længe = længe;
        }
    }
}
