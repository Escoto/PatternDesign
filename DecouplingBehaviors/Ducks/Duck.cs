using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouplingBehaviors
{
    public abstract class Duck
    {
        public IQuackBehavior quackBehavior;
        public IFlyBehavior flyBehavior;

        public Duck() { }

        public abstract void Display();

        public void PerformFly() 
            => flyBehavior.Fly();

        public void PerformQuack()
            => quackBehavior.Quack();

        public void PerformFloat() 
           => Console.WriteLine("All ducks float!");
        
        public void SetFlyBehavior(IFlyBehavior fb)
            => flyBehavior = fb;
        
        public void SetQuackBehavior(IQuackBehavior qb)
            => quackBehavior = qb;
    }
}
