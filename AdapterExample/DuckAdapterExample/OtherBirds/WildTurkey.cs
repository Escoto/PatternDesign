using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class WildTurkey : ITurkey
    {
        public void flyLikeTurkey() {
            Console.WriteLine("Flying like a Turkey!!");
        }

        public void gobble() {
            Console.WriteLine("Gobble gobble!!");
        }
    }
}
