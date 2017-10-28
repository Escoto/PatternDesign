using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouplingBehaviors
{
    public class MiniDuckSimulator
    {
        static Duck mallard, model;
        public static void Start() {
            mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
