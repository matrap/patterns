namespace Visitor
{
    public class Kitchen : IRoom
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetName()
        {
            return "Kitchen";
        }
    }
}
