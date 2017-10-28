using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouplingBehaviors
{
    public abstract class Duck
    {
        IQuackBehavior quackBehavior;
        IFlyBehavior flyBehavior;

        public Duck() { }

        public abstract void display();

        public void performFly() {
            flyBehavior.Fly();
        }

        public void performQuack() {
            quackBehavior.Quack();
        }

        public void performFloat() {
            Console.WriteLine("All ducks float!");
        }
    }
}
