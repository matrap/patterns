namespace Visitor
{
    public class Bathroom : IRoom
    {

        private string _roomName;

        public Bathroom()
        {
            _roomName = "Bathroom";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetName()
        {
            return _roomName;
        }
    }
}
