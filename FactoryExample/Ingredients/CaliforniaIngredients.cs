using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class CaliforniaIngredients : IIngredientFactory
    {
        public void PrepareDough() => Console.WriteLine("Preparing California Style Dough");

        public void PrepareSauce() => Console.WriteLine("Preparing California Style Sauce");
    }
}
