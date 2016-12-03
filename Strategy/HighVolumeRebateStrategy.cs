
namespace Strategy
{
    public class HighVolumeRebateStrategy : IRebateStrategy
    {
        public float CalculateRebate(int volume)
        {
            if(volume < 10)
            {
                return 0.01f;
            }
            else
            {
                return 0.05f;
            }
        }
    }
}
