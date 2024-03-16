using Pattern_3.Patterns.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Command.Commands
{
    public class ToggleFanCommand : Command
    {
        private Fan fan;

        public ToggleFanCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.ToggleFan();
        }
    }
}
