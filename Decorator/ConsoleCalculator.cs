using System;

namespace Decorator
{
    public class ConsoleCalculator : IConsoleCalculator
    {
        public ICalculator Calculator { get; private set; }

        public ConsoleCalculator(ICalculator calculator)
        {
            Calculator = calculator;
        }

        public int Add(int a, int b)
        {
            int sum = Calculator.Add(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            return sum;
        }
    }
}
