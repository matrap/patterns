using System;

namespace Visitor
{

    public class ConsoleVisitor : IVisitor
    {
        private int numberOfKitchens;
        private int numberOfBathrooms;

        public virtual void Visit(Kitchen room)
        {
            numberOfKitchens++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{room.GetName()} {numberOfKitchens}");
            Console.ResetColor();
        }

        public virtual void Visit(Bathroom room)
        {
            numberOfBathrooms++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{room.GetName()} {numberOfBathrooms}");
            Console.ResetColor();
        }

        public virtual void Visit(Apartment room)
        {
            Console.WriteLine(room.GetName());
        }
    }
}
