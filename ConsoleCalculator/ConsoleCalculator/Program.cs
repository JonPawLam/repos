using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("             Lommeregner! :D");
            Console.WriteLine("____________________________________________\n");

            bool open = true;
            while (open == true)
            {
                bool loop = true;
                 
                Console.WriteLine("First number");
                double first1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Choose + - * / or stop");
                string tegn = Console.ReadLine();
                while ( loop == true)
                    {

                        if (tegn == "+")
                        {
                            Console.WriteLine("Secund number");
                        double first2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(SimpleMathLibrary.SimpleMath.Add(first1, first2));
                        loop = false;
                        }

                        if (tegn == "-")
                        {
                            Console.WriteLine("Secund number");
                        double first2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(SimpleMathLibrary.SimpleMath.Subtract(first1, first2));
                        loop = false;
                        }

                        if (tegn == "*")
                        {
                            Console.WriteLine("Secund number");
                        double first2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(SimpleMathLibrary.SimpleMath.Multiply(first1, first2));
                        loop = false;
                        }

                        if (tegn == "/")
                        {
                            Console.WriteLine("Secund number");
                        double first2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(SimpleMathLibrary.SimpleMath.Divide(first1, first2)); 
                        loop = false;
                        }

                        if (tegn == "STOP")
                        {
                            open = false;
                            loop = false;
                        }
                        
                        if (tegn !="STOP" && tegn != "+" && tegn != "-" && tegn != "*" && tegn != "/")
                        {
                            Console.WriteLine("Wrong input, choose + - * or /");
                        }


                    }
                    

            }


            
        }

        
    }
}
