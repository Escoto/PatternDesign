using MyGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class StarbuzzCoffee : IInitialStep
    {
        public void Start()
        {
            Beverage b1 = new Espresso();
            printReceipt(b1);

            Beverage b2 = new HouseBlend();
            b2 = new Mocha(b2);
            b2 = new Mocha(b2);
            b2 = new Whip(b2);
            printReceipt(b2);

            Beverage b3 = new DarkRoast();
            b3 = new Mocha(b3);
            printReceipt(b3);
        }

        private void printReceipt(Beverage b) {
            Console.WriteLine($"{ b.GetDescription() } ${ b.Cost() }");
        }
    }
}
