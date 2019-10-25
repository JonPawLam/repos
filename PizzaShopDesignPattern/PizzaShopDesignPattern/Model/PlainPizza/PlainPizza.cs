using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model.Abstract;

namespace PizzaShopDesignPattern.Model.PlainPizza
{
    class PlainPizza : AbstractPizza
    {

        public PlainPizza()
        {
            this.Ingredients.Add("Tomato Source");
        }

        public override string ToString()
        {
            return ("Tomato Source");
        }
    }
}
