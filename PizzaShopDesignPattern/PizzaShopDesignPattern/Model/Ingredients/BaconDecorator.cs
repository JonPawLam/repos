using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model.Abstract;

namespace PizzaShopDesignPattern.Model.Ingredients
{
    class BaconDecorator : AbstractPizzaDecorator
    {
        public BaconDecorator(AbstractPizza pizza)
        {

            pizza.Ingredients.Add("Bacon");
        }

        public override string ToString()
        {
            return("Bacon");
        }
    }
}
