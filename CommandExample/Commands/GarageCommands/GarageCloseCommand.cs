using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class GarageCloseCommand : ICommand
    {
        Garage garage;
        public GarageCloseCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void Execute()
            => garage.Close();

        public void Undo()
            => garage.Open();
    }
}
