using System;

namespace Visitor
{
    public class ConsoleVisitor : IVisitor
    {
        public void Visit(IRoom room)
        {
            Console.WriteLine(room.GetName());
        }
    }
}
