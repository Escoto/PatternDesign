﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouplingBehaviors
{
    class Quacks : IQuackBehavior
    {
        public void Quack() {
            Console.WriteLine("Quacks");
        }
    }
}
