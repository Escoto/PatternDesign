using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;
using static FactoryExample.SimplePizzaFactory;

namespace FactoryExample
{
    public class PizzaStore : IInitialStep
    {
        public void Start()
        {
            IPizza pepperoni =  makePizza(PizzaType.Pepperoni);
            servePizza(pepperoni);

            servePizza(makePizza(PizzaType.Cheese));
        }

        private void servePizza( IPizza pizza)
            => Console.WriteLine(pizza.Open());
        
        private IPizza makePizza(PizzaType type) {

            IPizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
