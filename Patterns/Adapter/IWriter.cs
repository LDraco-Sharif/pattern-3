using Pattern_3.Patterns.Adapter.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Adapter
{
    public interface IWriter
    {
        abstract void Write(TypeMain mainType);
    }
}
