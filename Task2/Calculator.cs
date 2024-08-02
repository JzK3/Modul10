using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        { 
        Logger = logger;
        }

        public int Calculate(int x, int y)
        {

            Logger.Event(x,y);

            return x + y;
        }
    }
}
