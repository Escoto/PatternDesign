using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class Garage
    {
        public void Open()
            => Console.WriteLine("Garage Open");

        public void Close()
            => Console.WriteLine("Garage Close");
    }
}
