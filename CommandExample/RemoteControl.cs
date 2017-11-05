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
        ControlButton undo;
        Garage garage = new Garage();
        Light light = new Light();

        public RemoteControl() {
            undo = new ControlButton(new NoCommand());

            for (int i = 0 ; i < 10 ; i++) 
                buttons.Add(new ControlButton(new NoCommand()));
        }

        public void Start()
        {
            SetCommand(0, new LightOnCommand(light));
            SetCommand(1, new LightOffCommand(light));
            SetCommand(2, new GarageOpenCommand(garage));

            buttonWasPushed(0);
            undoWasPushed();
            buttonWasPushed(2);
            undoWasPushed();
        }

        public void SetCommand(int slot, ICommand onCommand)
            => buttons[slot].SetCommand(onCommand);
        
        private void buttonWasPushed(int btn) {
            undo = buttons[btn];
            buttons[btn].Execute();
        }

        private void undoWasPushed()
            => undo.ExecuteUndo();
    }
}
