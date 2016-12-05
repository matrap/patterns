namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new ConsoleVisitor();
            IRoom kitchen = new Kitchen();
            IRoom bathroom = new Bathroom();

            kitchen.Accept(visitor);
            bathroom.Accept(visitor);
        }
    }
}
