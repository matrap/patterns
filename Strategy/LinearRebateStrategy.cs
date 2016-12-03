
namespace Strategy
{
    public class LinearRebateStrategy : IRebateStrategy
    {
        public float CalculateRebate(int volume)
        {
            if (volume < 3)
            {
                return 0.029f;
            }
            else
            {
                return 0.031f;
            }
        }
    }
}
