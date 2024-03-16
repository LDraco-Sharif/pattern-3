using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Command
{
    public class Invoker
    {
        private Command? command = null;
        public void setCommand(Command command) 
        {
            this.command = command;
        }

        public void executeCommand()
        {
            if(command != null)
            {
                command.Execute();
            }
            
        }
    }
}
