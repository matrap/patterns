using Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator standardCalc = new StandardCalculator();
            ICalculator consoleCalc = new ConsoleCalculator(standardCalc);
            int a = 5;
            int b = 7;
            Console.WriteLine("Output from ConsoleCalculator:");
            int consoleSum = consoleCalc.Add(5, 7);
            Console.WriteLine("Output rewrite from result of method: {0}", consoleSum);
        }
    }
}
