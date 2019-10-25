using System;
using System.Collections.Generic;

namespace CalculatorLibrary
{
    public class Class1
    {
        //Prob for number in use
        public  double Result { get; set; }
        //Not in use
        public List<double> History= new List<double>() ;
        
        // +

        public double plus(double Number1, double Number2)
        {
            Result = Number1 + Number2;
            History.Add(Result);
            return Result;
        }


        // -

        public double Minus(double Number1, double Number2)
        {
            Result = Number1 - Number2;
            History.Add(Result);
            return Result;
        }


        // x

        public double Multiply(double Number1, double Number2)
        {
            Result = Number1 * Number2;
            History.Add(Result);
            return Result;
        }


        // /

        public double Divide(double Number1, double Number2)
        {
            Result = Number1 / Number2;
            History.Add(Result);
            return Result;
        }
    }
}
