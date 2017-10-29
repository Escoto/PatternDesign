using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string GetDescription()
            => $"{beverage.GetDescription()}, Mocha";

        public override double Cost() 
            => beverage.Cost() + .20;
    }
}
