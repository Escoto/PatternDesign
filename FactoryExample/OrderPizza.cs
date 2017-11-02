using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;

namespace FactoryExample
{
    public class OrderPizza : IInitialStep
    {
        
        public void Start()
        {
            PizzaStore californiaStore = new CaliforniaPizzaFactory();
            Pizza pepperoni = californiaStore.OrderPizza(PizzaStore.PizzaType.Pepperoni);
            servePizza(pepperoni);

            PizzaStore chicagoStore = new ChicagoPizzaFactory();
            Pizza greek = chicagoStore.OrderPizza(PizzaStore.PizzaType.Greek);
            servePizza(greek);

        }

        private void servePizza(Pizza pizza)
            => Console.WriteLine(pizza.Open());

    }
}
