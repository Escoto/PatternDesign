using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public ChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public void Fill() {
            if (isEmpty())
                empty = false;
        }

        public void Boil() {
            if (!isEmpty() && !isBoiled())
                boiled = true;
        }
        
        public void Drain() {
            if (!isEmpty() && isBoiled()) {
                empty = true;
                boiled = false;
            }
        }

        private bool isEmpty() => empty;
        private bool isBoiled() => boiled;
    }
}
