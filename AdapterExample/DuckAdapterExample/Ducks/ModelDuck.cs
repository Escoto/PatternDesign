using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class ModelDuck : Duck
    {
        public ModelDuck() {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quacks();
        }
        public override void Display()
            => Console.WriteLine("I'm a model Duck.");
    }
}
