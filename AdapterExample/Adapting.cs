using MyGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class Adapting : IInitialStep
    {
        enum Adapt { Ducks };

        public void Start()
        {
            Adapt toAdapt = Adapt.Ducks;

            switch (toAdapt) {
                case Adapt.Ducks: AdaptDucks(); break;
            }
        }

        private void AdaptDucks() {
            Duck turkey = new TurkeyAdapter(new WildTurkey());
            turkey.PerformFly();
            turkey.PerformQuack();
        }
    }
}
