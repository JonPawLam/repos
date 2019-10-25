using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Exception Test");

            bool stackExist = true;
            if (stackExist == true)
            {

                Console.WriteLine("Size of array?");
                MyStack<int>  myStack = new MyStack<int>(Convert.ToInt32(Console.ReadLine()));
                stackExist = false;
                Console.Clear();


                bool loop = true;
                string userInput;


                while (loop == true)
                {
                    Console.WriteLine("Add press (A)");
                    Console.WriteLine("Remove press (R)");
                    Console.WriteLine("See stack (T)");
                    Console.WriteLine("Exit (X)");

                    userInput = (Console.ReadLine());

                    if (userInput == "A")
                    {
                        try
                        {
                            myStack.Push(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            
                        }

                        
                    }

                    if (userInput == "R")
                    {
                        try
                        {
                            myStack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    if (userInput == "T")
                    {
                        try
                        {

                            Console.Clear();

                            myStack.ListView();
                        }
                        catch 
                        {
                            Console.WriteLine("Ingen Liste");
                            throw;
                        }

                    }


                    if (userInput == "X")
                    {
                        loop = false;


                    }


                    //else
                    //{
                    //    Console.WriteLine("Choose between A or R");

                    //}
                    
                }
            }
        }
    }
}
