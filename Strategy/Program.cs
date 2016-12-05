using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy pattern");

            IRebateStrategy linear = new LinearRebateStrategy();
            ProductPrize books = new ProductPrize(linear);
            float booksPrize = books.CalculateFinalPrize(5, 15);
            Console.WriteLine("Books final prize: {0}", booksPrize);

            IRebateStrategy highVolume = new HighVolumeRebateStrategy();
            ProductPrize spoons = new ProductPrize(highVolume);
            float spoonsPrize = spoons.CalculateFinalPrize(5, 15);
            Console.WriteLine("Spoons final prize: {0}", spoonsPrize);
        }
    }
}
