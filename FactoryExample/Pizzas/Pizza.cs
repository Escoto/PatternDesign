using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public abstract class Pizza
    {
        public IIngredientFactory ingredientFactory = new DefaultPizzaIngredients();
        public string pizzaName;

        public virtual void Prepare() {
            ingredientFactory.PrepareDough();
            ingredientFactory.PrepareSauce();
        }

        public virtual void Bake() { }

        public virtual void Cut() { }

        public virtual void Box() { }

        public virtual string Open() => pizzaName;

        public virtual void AddPizzeriaName(string pizzeriaName) {
            pizzaName = $"{pizzeriaName} {pizzaName}";
        }
    }
}
