using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class CeilingFanOffCommand : CeilingFanCommand, ICommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan) {
            this.ceilingFan = ceilingFan;
        }

        public override void Execute() {
            base.Execute();
            ceilingFan.Off();
        }

        public override void Undo() {
            base.Undo();
        }
    }
}
