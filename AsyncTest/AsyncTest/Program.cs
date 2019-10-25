using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace AsyncTest
{
    class Program
    {



        static void Main(string[] args)
        {
            Task.Run(() => Print("A"));
            Task.Run(() => Print("B"));
            Task.Run(() => Print("C"));
            Task.Run(() => Print("D"));


            Thread t1 = new Thread(() => Print("A"));
            t1.Name = "t1";
     
            Thread t2 = new Thread(() => Print("B"));

            t2.Name = "t2";

            Thread t3 = new Thread(() => Print("C"));

            t3.Name = "t3";

            Thread t4 = new Thread(() => Print("D"));

            t4.Name = "t4";

            t1.Priority = ThreadPriority.Highest;
            t1.Start();
            t1.Join();

            t2.Priority = ThreadPriority.AboveNormal;
            t2.Start();
            t2.Join();

            t3.Priority = ThreadPriority.Normal;
            t3.Start();
            t3.Join();

            t4.Priority = ThreadPriority.BelowNormal;
            t4.Start();
            t4.Join();

            Console.ReadKey();
        }

        

        public static void Print(string massage)
        {


            if (massage=="A")
            { 
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Ben Don " + i + "Times" + " Hello Love1");
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(Thread.CurrentThread.Priority);
                    Thread.Sleep(10);
                }
            }


            if (massage == "B")
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Ben Don " + i + "Times"+" Hello Love2");
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(Thread.CurrentThread.Priority);
                    Thread.Sleep(20);
                }
            }


            if (massage == "C")
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Ben Don " + i + "Times"+ "Hello Love3");
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(Thread.CurrentThread.Priority);
                    Thread.Sleep(30);
                }
            }


            if (massage == "D")
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Ben Don "+i+ "Times" + " Hello Love4");
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(Thread.CurrentThread.Priority);
                    Thread.Sleep(40);
                }
            }

        }

    }
}
