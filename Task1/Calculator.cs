using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     public class Calculator : ICalculator
    {
        public int Calculate(int x, int y)
        {
            return x + y;
        }
    }
}
