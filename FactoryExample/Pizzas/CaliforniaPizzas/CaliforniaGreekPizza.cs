using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class CaliforniaGreekPizza : Pizza
    {
        public CaliforniaGreekPizza(IIngredientFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
            pizzaName = "Greek Pizza";
        }
    }
}
