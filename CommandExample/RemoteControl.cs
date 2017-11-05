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
        List<ControlButton> buttons = new List<ControlButton>();
        Garage garage = new Garage();
        Light light = new Light();
        ICommand command;

        public RemoteControl() {
            for (int i = 0; i<10; i++) {
                buttons.Add(new ControlButton(new NoCommand()));
            }
        }

        public void Start()
        {
            //set coomand Light On
            command = new LightOnCommand(light);
            buttons[0].SetCommand(command);
            buttons[0].buttonWasPressed();

            //set command Garage Open
            command = new GarageOpenCommand(garage);
            buttons[1].SetCommand(command);
            buttons[1].buttonWasPressed();
        }
    }
}
