using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class GarageOpenCommand : ICommand
    {
        Garage garage;
        public GarageOpenCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void Execute()
            => garage.Open();

        public void Undo()
            => garage.Close();
    }
}
