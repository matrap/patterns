using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var grandFather = new CompositePrinter();
            var father = new CompositePrinter();
            IPrinter x = new XPrinter();
            IPrinter y = new YPrinter();

            grandFather.Add(x);
            grandFather.Add(father);
            grandFather.Add(y);
            father.Add(x);
            father.Add(x);
            father.Add(y);

            Console.Write("Grandfather tree: ");
            grandFather.Print();
            Console.WriteLine();

            Console.Write("Father tree: ");
            father.Print();
            Console.WriteLine();
        }
    }
}
