using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class ControlButton
    {
        ICommand slot;

        public ControlButton(ICommand command)
        {
            slot = command;
        }
        
        public void SetCommand(ICommand command)
            => slot = command;

        public void buttonWasPressed()
            => slot.Execute();
    }
}
