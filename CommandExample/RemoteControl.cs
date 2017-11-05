using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;

namespace CommandExample
{
    public class RemoteControl : IInitialStep
    {
        ControlButton button = new ControlButton();
        Garage garage = new Garage();
        Light light = new Light();
        ICommand command;

        public void Start()
        {
            //set coomand Light On
            command = new LightOnCommand(light);
            button.SetCommand(command);
            button.buttonWasPressed();

            //set command Garage Open
            command = new GarageOpenCommand(garage);
            button.SetCommand(command);
            button.buttonWasPressed();
        }
    }
}
