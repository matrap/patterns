namespace Visitor
{
    public interface IRoom
    {
        void Accept(IVisitor visitor);
        string GetName();
    }
}