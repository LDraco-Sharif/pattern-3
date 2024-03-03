using Pattern_3.Patterns.Adapter.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Adapter
{
    internal class Feature
    {
        public void Write(TypeFeature featureType)
        {
            Console.WriteLine("Writing on " + featureType.featureName);
        }
    }
}
