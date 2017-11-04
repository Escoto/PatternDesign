using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class BasicSingleton
    {
        private static BasicSingleton uniqueInstance;

        private BasicSingleton() { }

        public static BasicSingleton GetInstance() {

            if (uniqueInstance == null)
                uniqueInstance = new BasicSingleton();

            return uniqueInstance;
        }
    }
}
