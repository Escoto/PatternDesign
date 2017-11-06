using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class CeilingFanHighCommand : CeilingFanCommand, ICommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan) {
            this.ceilingFan = ceilingFan;
        }

        public override void Execute() {
            base.Execute();
            ceilingFan.High();
        }

        public override void Undo()
        {
            base.Undo();
        }
    }
}
