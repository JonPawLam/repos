using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rullete
{
    class Program
    {
        static void Main(string[] args)
        {
            int bet = 0;
            int tab = 0;
            int vundet = 0;
            int forsøg = 0;

            //extra
            int vundetITræk = 0;
            int tabtITræk = 0;
            int MaxPenge = 0;
            int MaxBet = 0;

            //penge
            int penge;
            Console.WriteLine("Vælg startbeløb");
            penge = Convert.ToInt32(Console.ReadLine());

            while ( penge>=0 )
            {
                
                //betCheck
                if (bet==0)
                {
                    //Hvis ingen tab, bet ++ penge --
                    if (tab == 0)
                    {
                        penge--;
                        bet++;
                        forsøg++;
                        vundet = 0;
                    }
                    //tager tab og laver nyt bet
                    else
                    {
                        bet = tab*2;
                        penge -= tab*2;
                        forsøg++;
                        tab = 0;
                        vundet = 0;

                        //max Bet
                        if (MaxBet <= bet)
                        {
                            MaxBet = bet;
                        }
                    }
                }

                //Rullette
                //37

                Random r = new Random();
                int rulleteslag = r.Next(0,37);

                //win con
                //giver penge bet*2
                if (rulleteslag >= 18)
                {
                    penge += (bet*2);
                    vundet = (bet * 2);
                    bet = 0;

                    //Vundet i træk tjek
                        vundetITræk++;
                        tabtITræk=0;

                    //max Penge
                    if(MaxPenge <=penge)
                    {
                        MaxPenge = penge;
                    }
                }
                //giver tab bet verdi*2
                //gør bet til 0
                else if (rulleteslag <= 19)
                {
                    tab = bet;
                    bet = 0;
                    tabtITræk ++;
                    vundetITræk = 0;
                }

                //udskriver hvad der er sket denne rundte
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("Forsøg nummer: " + forsøg);
                Console.WriteLine("gevinst: " + vundet);
                Console.WriteLine("tab: " + tab);
                Console.WriteLine("Penge Tilbage: "+penge);
                if (vundetITræk>=0)
                {
                    Console.WriteLine("Vundet i træk");
                    Console.WriteLine(vundetITræk);
                }
                if (tabtITræk>=0)
                {
                    Console.WriteLine("tabt I træk");
                    Console.WriteLine(tabtITræk);
                }
            }
            Console.WriteLine("Max bet var:" + MaxBet);
            Console.WriteLine("Max penge var:" + MaxPenge);
            Console.ReadKey();
        }
    }
}
