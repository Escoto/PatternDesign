using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouplingBehaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly() {
            Console.WriteLine("I can't fly :'( ");
        }

    }
}
