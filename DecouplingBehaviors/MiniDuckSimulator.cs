﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;

namespace DecouplingBehaviors
{
    public class MiniDuckSimulator : IInitialStep
    {
        Duck mallard, model;
        public void Start() {
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
