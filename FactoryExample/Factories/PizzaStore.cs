using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;

namespace FactoryExample
{
    public abstract class PizzaStore
    {
        public enum PizzaType { Cheese, Greek, Pepperoni, CaliforniaGreek, CaliforniaPepperoni };

        public Pizza OrderPizza(PizzaType type) {

            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(PizzaType type);
    }
}
