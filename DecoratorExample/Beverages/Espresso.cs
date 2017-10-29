using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class Espresso : Beverage
    {
        public Espresso() {
            description = "Espresso";
        }

        public override double Cost() 
            => 1.99;
    }
}
