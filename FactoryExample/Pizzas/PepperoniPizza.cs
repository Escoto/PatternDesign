using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class PepperoniPizza : IPizza
    {
        public void Prepare() { }

        public void Bake() { }

        public void Cut() { }

        public void Box() { }
        public string Open()
        {
            return "Pepperoni Pizza";
        }
    }
}
