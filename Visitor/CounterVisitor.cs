using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class CounterVisitor : ConsoleVisitor
    {
        private int kitchens;
        private int bathrooms;

        public override void Visit(Kitchen room)
        {
            base.Visit(room);
            kitchens++;
        }

        public override void Visit(Bathroom room)
        {
            base.Visit(room);
            bathrooms++;
        }

        public void PublishCounter()
        {
            Console.WriteLine($"All kitchens: {kitchens}");
            Console.WriteLine($"All bathrooms: {bathrooms}");
        }
    }
}
