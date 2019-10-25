using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions_Predicate_Delegates_Andre_a
{
    class Car
    {
        
        //public string _name { get; set; }
        public string _type { get; set; }
        public int _realeaseYear { get; set; }

        public Car(string type, int realeaseYear)
        {
            _type = type;
            _realeaseYear = realeaseYear;
        }

        public override string ToString()
        {
            return $"{nameof(_type)}: {_type}, {nameof(_realeaseYear)}: {_realeaseYear}";
        }
    }
}
