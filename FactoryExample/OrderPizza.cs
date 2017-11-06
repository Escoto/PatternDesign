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
            PizzaStore chicagoStore = new ChicagoPizzaFactory();
            
            //California's pepperoni pizza
            Pizza pepperoni = californiaStore.OrderPizza(PizzaStore.PizzaType.CaliforniaPepperoni);
            servePizza(pepperoni);

            Console.WriteLine();
            
            //In chicago with generic pizzas
            Pizza greek = chicagoStore.OrderPizza(PizzaStore.PizzaType.Greek);
            servePizza(greek);

            Console.WriteLine();

            //They dont sell cheese in california :(
            Pizza cheese = californiaStore.OrderPizza(PizzaStore.PizzaType.Cheese);
            servePizza(cheese);
        }

        private void servePizza(Pizza pizza) => Console.WriteLine(pizza.Open());

    }
}
