using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3.Patterns.Strategy.Strategies
{
    public class Strat2 : Strategy
    {
        public void performTask()
        {
            Console.WriteLine("Task performed with Strat1");
        }
    }
}
