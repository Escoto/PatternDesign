using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class NotFoundPizza : Pizza
    {
        public override void Prepare() { }
        public override void Bake() { }

        public override void Cut() { }

        public override void Box() { }

        public NotFoundPizza() {
            pizzaName = "Sorry! we dont sell that pizza here.";
        }

        public override void AddPizzeriaName(string pizzeriaName) { }

    }
}
