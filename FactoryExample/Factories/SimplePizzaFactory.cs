using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{

    /**
     * This class was ussed only for the initial example.
     * The project muted into a more complex solution with multiple factories.
     * 
     */

    public static class SimplePizzaFactory
    {
        public enum PizzaType { Cheese, Greek, Pepperoni };

        public static Pizza CreatePizza(PizzaType type)
        {
            switch (type) {
                case PizzaType.Cheese:
                    return pizza<CheesePizza>();

                case PizzaType.Greek:
                    return pizza<GreekPizza>();

                case PizzaType.Pepperoni:
                    return pizza<PepperoniPizza>();

                default: return pizza<NotFoundPizza>();
            }
            
        }

        private static Pizza pizza<T>() where T : Pizza, new()
            => new T();
        
    }
}
