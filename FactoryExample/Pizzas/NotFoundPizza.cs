using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class NotFoundPizza : Pizza
    {
        public NotFoundPizza() {
            pizzaName = "Sorry! we dont dell that pizza here.";
        }

        public override void AddPizzeriaName(string pizzeriaName) { }

    }
}
