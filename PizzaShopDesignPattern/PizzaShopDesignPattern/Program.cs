using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model;
using PizzaShopDesignPattern.Model.Ingredients;
using PizzaShopDesignPattern.ViewConsole;

namespace PizzaShopDesignPattern
{
    class Program 
    {
        
        static void Main(string[] args)
        {

            // Test Of Bacon class
            //BaconDecorator baconDecorator = new BaconDecorator();

            //Test of PizzaFactory


            Resturent resturent = new Resturent();
            resturent.ResturentRun();

            
        }
    }
}
