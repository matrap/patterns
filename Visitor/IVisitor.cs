namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Kitchen room);
        void Visit(Bathroom room);
        void Visit(Apartment room);
    }
}