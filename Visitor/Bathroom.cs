namespace Visitor
{
    using System.Collections.Generic;

    public class Bathroom : IRoom
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetName()
        {
            return "Bathroom";
        }
    }
}
