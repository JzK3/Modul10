using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);

        }

        public void Event(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{x}, {y}");
        }
    }
}
