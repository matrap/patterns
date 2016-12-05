using System;

namespace Composite
{
    public class XPrinter : IPrinter
    {
        public void Print()
        {
            Console.Write("X");
        }
    }
}
