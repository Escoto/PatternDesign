using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public abstract class CeilingFanCommand : ICommand
    {
        public CeilingFan ceilingFan;
        public CeilingFan.speeds prevSpeed;

        public virtual void Execute() {
            prevSpeed = ceilingFan.GetSpeed();
        }

        public virtual void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFan.speeds.High:
                    ceilingFan.High();
                    break;
                case CeilingFan.speeds.Medium:
                    ceilingFan.Medium();
                    break;
                case CeilingFan.speeds.Low:
                    ceilingFan.Low();
                    break;
                case CeilingFan.speeds.Off:
                    ceilingFan.Off();
                    break;
            }
        }
    }
}
