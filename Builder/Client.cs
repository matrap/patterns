using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Client
    {
        public ICar BuyPeugeot()
        {
            PeugeotBuilder builder = new PeugeotBuilder();
            CarProvider provider = new CarProvider(builder);
            ICar peugeot = provider.Construct(2015);
            return peugeot;
        }

        public ICar BuySkoda()
        {
            SkodaBuilder builder = new SkodaBuilder();
            CarProvider provider = new CarProvider(builder);
            ICar skoda = provider.Construct(2016);
            return skoda;
        }
    }
}
