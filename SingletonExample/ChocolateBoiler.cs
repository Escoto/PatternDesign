using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class ChocolateBoiler
    {
        private static ChocolateBoiler uniqueBiler;
        private bool empty;
        private bool boiled;

        private ChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance() {
            if (uniqueBiler == null)
                uniqueBiler = new ChocolateBoiler();

            return uniqueBiler;
        }

        public void Fill() {
            if (isEmpty()) {
                empty = false;
                boiled = false;

                Console.WriteLine("Filling Boiler with Mixture");
            }
        }

        public void Boil() {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;

                Console.WriteLine("Boiling Mixture in Boiler");
            }
        }
        
        public void Drain() {
            if (!isEmpty() && isBoiled()) {
                empty = true;
                boiled = false;

                Console.WriteLine("Draining Boiler's Mixture");
            }
        }

        private bool isEmpty() => empty;
        private bool isBoiled() => boiled;
    }
}
