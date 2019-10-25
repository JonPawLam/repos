using System;
using System.Collections.Generic;


namespace CalculatorLibraryCore
{
    /// <summary>
    /// CalculatorClass is a library, that does MUCH LESS than the "math" library all ready in use. In joy :)
    /// </summary>
    public class CalculatorClass
    {
        //Prob for number in use
        public double Result { get; set; }


        //List off Results in the program
        public List<double> History = new List<double>();


        // + plus

        public double plus(double Number1, double Number2)
        {
            Result = Number1 + Number2;
            History.Add(Result);
            return Result;
        }


        // - Minus

        public double Minus(double Number1, double Number2)
        {
            Result = Number1 - Number2;
            History.Add(Result);
            return Result;
        }


        // x Multiply

        public double Multiply(double Number1, double Number2)
        {
            Result = Number1 * Number2;
            History.Add(Result);
            return Result;
        }


        // / Divide

        public double Divide(double Number1, double Number2)
        {
            Result = Number1 / Number2;
            History.Add(Result);
            return Result;
        }


        // History

        public List<double> history()
        {
            return History;
        }
        


        //Advanced math
        
        public double Asinh(double Number1)
        {
            Result = Math.Asinh(Number1);
            History.Add(Result);
            return Result;
        }


        //Acos

        public double Acos(double Number1)
        {
            Result = Math.Acos(Number1);
            History.Add(Result);
            return Result;
        }


        //Acosh

        public double Acosh(double Number1)
        {
            Result = Math.Acosh(Number1);
            History.Add(Result);
            return Result;
        }


        //Asin

        public double Asin(double Number1)
        {
            Result = Math.Asin(Number1);
            History.Add(Result);
            return Result;
        }


        //Atan

        public double Atan(double Number1)
        {
            Result = Math.Atan(Number1);
            History.Add(Result);
            return Result;
        }


        //Atan2

        public double Atan2(double Number1, double Number2)
        {
            Result = Math.Atan2(Number1, Number2);
            History.Add(Result);
            return Result;
        }


        //Atanh

        public double Atanh(double Number1)
        {
            Result = Math.Atanh(Number1);
            History.Add(Result);
            return Result;
        }


        //Cbrt

        public double Cbrt(double Number1)
        {
            Result = Math.Cbrt(Number1);
            History.Add(Result);
            return Result;
        }


        //Sin

        public double Sin(double Number1)
        {
            Result = Math.Sin(Number1);
            History.Add(Result);
            return Result;
        }


        //Cos

        public double Cos(double Number1)
        {
            Result = Math.Cos(Number1);
            History.Add(Result);
            return Result;
        }


        //Sinh

        public double Sinh(double Number1)
        {
            Result = Math.Sinh(Number1);
            History.Add(Result);
            return Result;
        }


        //Tan

        public double Tan(double Number1)
        {
            Result = Math.Tan(Number1);
            History.Add(Result);
            return Result;
        }


        //Sqrt

        public double Sqrt(double Number1)
        {
            Result = Math.Sqrt(Number1);
            History.Add(Result);
            return Result;
        }
    }
}
