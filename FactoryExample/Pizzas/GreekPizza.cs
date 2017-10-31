using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class GreekPizza : IPizza
    {
        public void Bake()
        {
        }

        public void Box()
        {
        }

        public void Cut()
        {
        }

        public void Prepare()
        {
        }
        public string Open()
        {
            return "Greek Pizza";
        }
    }
}
