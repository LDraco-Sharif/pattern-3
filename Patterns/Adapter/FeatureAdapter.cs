using Pattern_3.Patterns.Adapter.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Adapter
{
    internal class FeatureAdapter : IWriter
    {
        private Feature feature = new();
        public void Write(TypeMain mainType)
        {
            feature.Write(MainToFeature(mainType));
        }

        private TypeFeature  MainToFeature(TypeMain main)
        {
            TypeFeature feature = new();
            feature.featureName = main.mainName;
            return feature;
        } 
    }
}
