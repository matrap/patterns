namespace Visitor
{
    public class Kitchen : IRoom
    {
        private string _roomName;

        public Kitchen()
        {
            _roomName = "Kitchen";
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
