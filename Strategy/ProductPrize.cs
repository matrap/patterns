
namespace Strategy
{
    public class ProductPrize
    {
        private IRebateStrategy _rebate;

        public ProductPrize(IRebateStrategy rebate)
        {
            _rebate = rebate;
        }

        public float CalculateFinalPrize(int volume, float prize)
        {
            float rebate = 1 - _rebate.CalculateRebate(volume);
            return volume * prize * rebate;
        }
    }
}
