using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class MallardDuck : Duck
    {
        public MallardDuck() {
            quackBehavior = new Quacks();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
            => Console.WriteLine("I'm a real Mallar Duck.");
    }
}
