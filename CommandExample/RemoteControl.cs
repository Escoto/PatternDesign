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
        readonly int buttonNumber = 3;
        List<ControlButton> buttons;
        ControlButton undoButton;
        Garage garage = new Garage();
        Light light = new Light();

        public RemoteControl() {
            buttons = Enumerable
                .Range(0, buttonNumber)
                .Select(x => new ControlButton())
                .ToList();

            undoButton = new ControlButton();
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
            undoButton = buttons[btn];
            buttons[btn].Execute();
        }

        private void undoWasPushed()
            => undoButton.ExecuteUndo();
    }
}
