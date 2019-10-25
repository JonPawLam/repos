using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model;

namespace PizzaShopDesignPattern.ViewConsole
{
     class Resturent
     {
         private PizzaFactory _pizzaFactory { get; set; }


         private bool addMoreTopping = true;
         private string toppingchoices;
         //private string[] order;
         private bool userErrorTest = true;
         private bool userErrorTestDoneWithToppings = true;


         private string UserInput;



        public Resturent()
        {
            ResturentRun();
        }



        //Sale
        public void ResturentRun()
        {

            PizzaFactory pizzaFactory = new PizzaFactory();

            while (addMoreTopping==true)
            {
            Console.WriteLine("----------------------Type what kind of topping-------------------------------");
            Console.WriteLine("                 Bacon          Ham          Pepperoni        ");



                


                var order = new List<string>();

                while (userErrorTestDoneWithToppings)
                {
                    
                    //Vælg Topping
                    while (userErrorTest == true)
                        {
                            
                            toppingchoices = (Console.ReadLine());
                            if (toppingchoices == "Bacon" || toppingchoices == "Ham" || toppingchoices == "Pepperoni")
                            { userErrorTest = false;}
                            else
                            {
                             Console.WriteLine("That did not make any sense... try agian.");
                            }
                            //Add Topping
                            order.Add(toppingchoices);

                        }
                            
                         //vælg flere topping?
                            Console.WriteLine("More Toppings? Y -yes N -No");
                            UserInput = Console.ReadLine();
                    

                            if (UserInput == "N")
                            {
                                addMoreTopping = false;
                                userErrorTestDoneWithToppings = false;
                            }

                            else if (UserInput == "Y")
                            {
                                userErrorTest = true;
                            }

                            else
                            {
                                Console.WriteLine("Sorry i failed to understand");
                            }
                    

                 }
                

                //Print Pizza
                Console.WriteLine(pizzaFactory.MakePizza(order));
                Console.ReadKey();



            }

            Console.Clear();
            
        }


         public void MorePizzaTopping()
         {
             

         }
        
    }
}
