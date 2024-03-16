using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Command.Receiver
{
    public class Document
    {
        private string Msg { get; } = "";
        public Document(string message)
        {
            Msg = message;
        }

        public void Read()
        {
            Console.WriteLine("Reading message: " + Msg);
        }

    }
}
