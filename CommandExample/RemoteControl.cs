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
        
        public RemoteControl() {
            for (int i = 0 ; i < 10 ; i++) 
                buttons.Add(new ControlButton(new NoCommand()));
        }

        public void Start()
        {
            SetCommand(0, new LightOnCommand(light));
            SetCommand(1, new LightOffCommand(light));
            SetCommand(2, new GarageOpenCommand(garage));

            ButtonWasPushed(0);
            ButtonWasPushed(1);
            ButtonWasPushed(2); //button 2 is not mapped to any command
        }

        public void SetCommand(int slot, ICommand onCommand)
            => buttons[slot].SetCommand(onCommand);


        public void ButtonWasPushed(int btn)
            => buttons[btn].buttonWasPressed();
    }
}
