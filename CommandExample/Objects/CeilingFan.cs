using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    public class CeilingFan
    {
        public enum speeds {Off, Low, Medium, High};
        string location;
        speeds speed;

        public CeilingFan(string location) {
            this.location = location;
        }

        public string GetLocation() => location;

        public void High() {
            speed = speeds.High;
            Console.WriteLine($"{location} fan speed {speed}");
        }
        public void Medium() {
            speed = speeds.Medium;
            Console.WriteLine($"{location} fan speed {speed}");
        }
        public void Low() {
            speed = speeds.Low;
            Console.WriteLine($"{location} fan speed {speed}");
        }
        public void Off() {
            speed = speeds.Off;
            Console.WriteLine($"{location} fan speed {speed}");
        }

        public speeds GetSpeed() => speed;
    }
}
