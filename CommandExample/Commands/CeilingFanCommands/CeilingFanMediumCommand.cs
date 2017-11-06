using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class CeilingFanMediumCommand : CeilingFanCommand, ICommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan) {
            this.ceilingFan = ceilingFan;
        }

        public override void Execute()
        {
            base.Execute();
            ceilingFan.Medium();
        }

        public override void Undo()
        {
            base.Undo();
        }
    }
}
