using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class CaliforniaPepperoniPizza : Pizza
    {
        public CaliforniaPepperoniPizza(IIngredientFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
            pizzaName = "Pepperoni Pizza";
        }
    }
}
