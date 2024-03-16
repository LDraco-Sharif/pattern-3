using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Command.Receiver
{
    public class Fan
    {
        public bool active = false;

        public void ToggleFan()
        {
            Console.WriteLine("Fan Status Before: " + active);
            active = !active;
            Console.WriteLine("Current Fan Status: " + active);
        }
    }
}
