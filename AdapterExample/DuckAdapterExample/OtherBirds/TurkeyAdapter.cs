using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class TurkeyAdapter : Duck
    {
        ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey) {
            this.turkey = turkey;
        }

        public override void Display() => Console.WriteLine("I'm a Turkey.");

        public override void PerformFly() {
            turkey.flyLikeTurkey();
        }

        public override void PerformQuack() {
            turkey.gobble();
        }
    }
}
