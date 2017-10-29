using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override double Cost()
            => 2.10;
    }
}
