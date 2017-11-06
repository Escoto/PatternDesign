using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryExample;
using MyGenerics;

namespace Tests
{
    [TestClass]
    public class FactoryExampleTests
    {
        [TestMethod()]
        public void OrderPizza_can_be_instantiated() {
            Assert.AreNotEqual(new OrderPizza(), null);
            Assert.IsInstanceOfType(new OrderPizza(), typeof(IInitialStep));
        }

        [TestMethod]
        public void Californias_Pizza_Test() {
            PizzaStore cStore = new CaliforniaPizzaFactory();
            Pizza pPizza = cStore.OrderPizza(PizzaStore.PizzaType.CaliforniaPepperoni);
            IIngredientFactory ingF = pPizza.ingredientFactory;

            //validate correct factory instance
            Assert.IsInstanceOfType(cStore, typeof(CaliforniaPizzaFactory));
            Assert.IsNotInstanceOfType(cStore, typeof(ChicagoPizzaFactory));

            //validate correct pepperoni pizza instance
            Assert.IsInstanceOfType(pPizza, typeof(CaliforniaPepperoniPizza));

            //validate correct california's ingredients factory
            Assert.IsInstanceOfType(ingF, typeof(CaliforniaIngredients));
        }
    }
}
