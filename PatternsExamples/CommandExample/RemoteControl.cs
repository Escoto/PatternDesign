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
        public void Start()
        {
            ControlButton button = new ControlButton();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            button.SetCommand(lightOn);
            button.buttonWasPressed();
        }
    }
}
