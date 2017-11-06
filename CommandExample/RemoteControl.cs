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
        readonly int buttonNumber = 10;
        List<ControlButton> buttons;
        ControlButton undoButton;
        Garage garage = new Garage();
        Light light = new Light();
        CeilingFan ceilingFan = new CeilingFan("Here");

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
            SetCommand(3, new GarageCloseCommand(garage));
            SetCommand(4, new CeilingFanOffCommand(ceilingFan));
            SetCommand(5, new CeilingFanLowCommand(ceilingFan));
            SetCommand(6, new CeilingFanMediumCommand(ceilingFan));
            SetCommand(7, new CeilingFanHighCommand(ceilingFan));

            buttonWasPushed(0);
            buttonWasPushed(1);
            buttonWasPushed(2);
            undoWasPushed();


            buttonWasPushed(4);
            buttonWasPushed(5);
            undoWasPushed();
            buttonWasPushed(6);
            undoWasPushed();
            buttonWasPushed(7);
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
