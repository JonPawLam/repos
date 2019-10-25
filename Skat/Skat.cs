using System;
using System.Linq.Expressions;

namespace Skat
{
    public class Afgift
    {
        private static double BilAfgiftUdregning;


        //Har sat de 2 metoder sammen, da Elbil metoden er reduntent. 
        //Da opjektet skal bruge en BilType, når der skal udregnes bilafgift.

        public static double BilAfgift(double BilValue, string BilType)
        {
            // Vi prøver udregne inden for denne metode
            try
            {
                //Vi undersøger om bilen er inden for vores kriterier
                if(BilValue > 0 && BilValue != Double.MaxValue)
                { 
                    //Hvis Bilen er en PersonBil, Udregner vi BilValue her.
                    if (BilType == "PersonBil")
                    {
                        if (BilValue <= 200000)
                        {
                            BilAfgiftUdregning = BilValue * 0.85;
                            if (BilAfgiftUdregning <= 0)
                            return BilAfgiftUdregning;
                        }
                        else
                        {
                        
                            BilAfgiftUdregning = (BilValue * 1.50) - 130000;
                            return BilAfgiftUdregning;
                        }
                    }
                    //Hvis Bilen er en ElBil, Udregner vi BilValue her.
                    if (BilType == "Elbil")
                    {
                        if (BilValue <= 200000)
                        {
                            BilAfgiftUdregning = (BilValue * 0.85) * 0.20;
                            return BilAfgiftUdregning;
                        }

                        if (BilValue > 200000)
                        {
                            BilAfgiftUdregning = ((BilValue * 1.50) - 130000) * 0.20;

                            return BilAfgiftUdregning;
                        }
                        
                    }
                    //return ArgumentOutOfRangeException hvis value er max, programmet kan håndtere. Dette er ikke realistik;
                }
                else if (BilValue == Double.MaxValue)
                {
                    
                    throw new ArgumentOutOfRangeException();
                    
                }

                return BilAfgiftUdregning;
            }
            
            //Catcher hvis der er fejl i Bilafgift
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BilAfgiftUdregning;
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
