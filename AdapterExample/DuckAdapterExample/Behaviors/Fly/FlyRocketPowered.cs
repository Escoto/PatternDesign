﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly() {
            Console.WriteLine("I'm rocket powered!!");
        }
    }
}
