using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarProvider
    {
        private ICarBuilder _carBuilder;

        public CarProvider(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public ICar Construct(int year)
        {
            ICar car = _carBuilder
                .InputEngine(1.4)
                .TakeFromConstructionYear(year)
                .AddDoor(2)
                .AddDoor(3)
                .Build();
            return car;
        }
    }
}
