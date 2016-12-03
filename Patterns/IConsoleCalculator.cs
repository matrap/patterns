
namespace Decorator
{
    public interface IConsoleCalculator : ICalculator
    {
        ICalculator Calculator { get; }
    }
}
