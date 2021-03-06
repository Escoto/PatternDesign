﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class CaliforniaPizzaFactory : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza;
            switch (type) {
                case PizzaType.CaliforniaGreek:
                    pizza = new CaliforniaGreekPizza(new CaliforniaIngredients());
                    break;
                case PizzaType.CaliforniaPepperoni:
                    pizza = new CaliforniaPepperoniPizza(new CaliforniaIngredients());
                    break;
                default: pizza = pizza<NotFoundPizza>();
                    break;
            }

            pizza.AddPizzeriaName("California's");

            return pizza;
        }

        private static Pizza pizza<T>() where T : Pizza, new()
            => new T();
    }
}
