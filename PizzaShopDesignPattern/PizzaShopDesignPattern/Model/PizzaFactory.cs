using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.InterFaces;
using PizzaShopDesignPattern.Model.Abstract;
using PizzaShopDesignPattern.Model.Ingredients;

namespace PizzaShopDesignPattern.Model
{
    class PizzaFactory : IPizzaFactory
    {
        //Plain Ref
        private PlainPizza.PlainPizza PlainPizza { get; set; }

        //Decorators Ref
        private BaconDecorator Bacon { get; set; }
        private HamDecorator Ham { get; set; }
        private PepperoniDecorator Pepperoni { get; set; }



        // Make new Pizza
        public AbstractPizza MakePizza(List<string> additional)
        {
            AbstractPizza pizza = new PlainPizza.PlainPizza();
            if (additional != null)
                foreach (var ingredients in additional)
                {
                    pizza = AddIngredients(ingredients, pizza);
                }
            return pizza;
        }


        public AbstractPizza AddIngredients(string ingredients, AbstractPizza pizza)
        {

            switch (ingredients)
            {
                case "Ham": return new HamDecorator(pizza);
                case "Pepperoni": return new PepperoniDecorator(pizza);
                case "Bacon": return new BaconDecorator(pizza);
                default: return pizza;
            }

        }
    }
}
