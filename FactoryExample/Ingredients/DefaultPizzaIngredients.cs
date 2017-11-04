using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class DefaultPizzaIngredients : IIngredientFactory
    {
        public void PrepareDough() => Console.WriteLine("Preparing Default Dough");

        public void PrepareSauce() => Console.WriteLine("Preparing Default Sauce");
    }
}
