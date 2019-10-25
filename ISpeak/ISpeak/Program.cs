using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpeak
{
    class Program
    {
        static void Main(string[] args)
        {


            ISpeak speaker = new Philosopher();
            Console.WriteLine(speaker.Speak());
            ((Philosopher) speaker).Think();


            bool _loop = true;
            string _userChoise;
            while (_loop == true)
            {
                Console.WriteLine("Læs tankerne på Hund tryk: 1         Læs tankerne på Ko tryk: 2          Læs tankerne på Frø tryk: 3         Afslut tryk: 9");
                _userChoise = Console.ReadLine();

                if (_userChoise == "1")
                {
                    speaker = new Dog();
                    Console.WriteLine(speaker.Speak());

                }

                else if (_userChoise == "2")
                {
                    speaker = new Cow();
                    Console.WriteLine(speaker.Speak());

                }

                else if (_userChoise == "3")
                {
                    speaker = new Frog();
                    Console.WriteLine(speaker.Speak());

                }

                else if (_userChoise == "9")
                {
                    _loop = false;

                }

                else
                {
                    Console.WriteLine("Fejl, vælg 1, 2, 3 eller 9");
                }

            }






           

        }
    }
}
