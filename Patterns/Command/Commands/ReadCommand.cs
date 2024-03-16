using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_3.Patterns.Command.Receiver;

namespace Pattern_3.Patterns.Command.Commands
{
    public class ReadCommand : Command
    {
        private Document doc;
        public ReadCommand(Document document)
        {
            this.doc = document;
        }
        public void Execute()
        {
            doc.Read();
        }
    }
}
