using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class CeilingFanLowCommand : CeilingFanCommand, ICommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan) {
            this.ceilingFan = ceilingFan;
        }
        public override void Execute()
        {
            base.Execute();
            ceilingFan.Low();
        }

        public override void Undo()
        {
            base.Undo();
        }
    }
}
