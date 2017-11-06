using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class CaliforniaGreekPizza : Pizza
    {
        public CaliforniaGreekPizza(IIngredientFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
            pizzaName = "Greek Pizza";
        }
    }
}
