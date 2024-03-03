using Pattern_3.Patterns.Adapter.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Adapter
{
    internal class Original : IWriter
    {
        public void Write(TypeMain main)
        {
            Console.WriteLine("Writing on " + main.mainName);
        }
    }
}
