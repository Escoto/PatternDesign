using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Singleton
    {
        private static Singleton uniqueInstance;
        
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Singleton();
            
            return uniqueInstance;
        }

    }

    class BasicSingletonA
    {
        private static BasicSingletonA uniqueInstanceA;
        
        private BasicSingletonA() { }

        public static BasicSingletonA GetInstanceA()
        {
            if(uniqueInstanceA == null)
                lock (uniqueInstanceA) {
                    uniqueInstanceA = new BasicSingletonA();
                }

            return uniqueInstanceA;
        }
        
    }

    class BasicSingletonB
    {
        private static BasicSingletonB uniqueInstanceB
            = new BasicSingletonB();

        private BasicSingletonB() { }
        

        public static BasicSingletonB GetInstanceB()
            => uniqueInstanceB;

    }
}
