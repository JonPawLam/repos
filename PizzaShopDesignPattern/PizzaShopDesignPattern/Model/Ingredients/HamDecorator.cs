using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model.Abstract;

namespace PizzaShopDesignPattern.Model.Ingredients
{
    class HamDecorator : AbstractPizzaDecorator
    {


        public HamDecorator(AbstractPizza pizza)
        {

            this.Ingredients.Add("Tomato Source");
        }



        public override string ToString()
        {
            return("Ham");
        }
    }
}
