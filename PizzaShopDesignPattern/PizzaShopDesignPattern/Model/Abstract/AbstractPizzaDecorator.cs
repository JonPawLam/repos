using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaShopDesignPattern.Model.Ingredients;

namespace PizzaShopDesignPattern.Model.Abstract
{
    abstract class AbstractPizzaDecorator : AbstractPizza
    {
        public AbstractPizza MainAbstractPizza { get; set; }
        

        

    }
}
