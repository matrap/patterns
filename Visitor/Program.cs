namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisitor console = new ConsoleVisitor();
            CounterVisitor counter = new CounterVisitor();
            IRoom kitchen = new Kitchen();
            IRoom bathroom = new Bathroom();
            IRoom apartment = new Apartment();

            kitchen.Accept(counter);
            bathroom.Accept(console);
            apartment.Accept(counter);

            console.Visit((Kitchen)kitchen);
            counter.PublishCounter();
        }
    }
}
