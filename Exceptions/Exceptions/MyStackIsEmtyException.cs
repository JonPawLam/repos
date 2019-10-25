using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyStackIsEmtyException : System.Exception
    {
        public MyStackIsEmtyException(string message) : base (message)
        {
            
        }
    }
}
