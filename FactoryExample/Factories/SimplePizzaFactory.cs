using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public static class SimplePizzaFactory
    {
        public enum PizzaType { Cheese, Greek, Pepperoni };

        public static IPizza CreatePizza(PizzaType type)
        {
            switch (type) {
                case PizzaType.Cheese:
                    return pizza<CheesePizza>();//new CheesePizza(); 

                case PizzaType.Greek:
                    return pizza<GreekPizza>();

                case PizzaType.Pepperoni:
                    return pizza<PepperoniPizza>();

                default: return pizza<NotFoundPizza>();
            }
            
        }

        private static IPizza pizza<T>() where T : IPizza, new()
            => new T();
        
    }
}
