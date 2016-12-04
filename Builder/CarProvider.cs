using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarProvider
    {
        private SkodaBuilder _skodaBuilder = new SkodaBuilder();
        private PeugeotBuilder _peugeotBuilder = new PeugeotBuilder();

        public Peugeot ConstructPeugeot(int year)
        {
            Peugeot car = _peugeotBuilder
                .AddDoor(2)
                .InputEngine(1.4)
                .TakeFromConstructionYear(year)
                .Build();
            return car;
        }

        public Skoda ConstructSkoda(int year)
        {
            Skoda car = _skodaBuilder
                .InputEngine(1.6)
                .TakeFromConstructionYear(year)
                .AddDoor(2)
                .AddDoor(3)
                .Build();
            return car;
        }
    }
}
