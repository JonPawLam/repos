﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyStackIsFullException : System.Exception
    {
        public MyStackIsFullException(string message) : base (message)
        {


        }
        
            
        
    }
}
