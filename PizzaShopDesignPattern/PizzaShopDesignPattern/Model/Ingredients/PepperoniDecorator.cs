using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model.Abstract;

namespace PizzaShopDesignPattern.Model.Ingredients
{
    class PepperoniDecorator : AbstractPizzaDecorator
    {

        public PepperoniDecorator(AbstractPizza pizza)
        {

            this.Ingredients.Add("Tomato Source");
        }

        public override string ToString()
        {
            return("Pepperoni");
        }
    }
}
