﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public interface IPizza
    {
        void Prepare();

        void Bake();

        void Cut();

        void Box();

        string Open();
    }
}
