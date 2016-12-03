using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class SkodaBuilder : ICarBuilder
    {
        private double _engineVolume;
        private int _doors;
        private int _yearOfConstruction;

        public ICarBuilder InputEngine(double volume)
        {
            _engineVolume = volume;
            return this;
        }

        public ICarBuilder AddDoor(int number)
        {
            _doors = _doors + number;
            return this;
        }

        public ICarBuilder TakeFromConstructionYear(int year)
        {
            _yearOfConstruction = year;
            return this;
        }

        public ICar Build()
        {
            Skoda product = new Skoda(_engineVolume, _doors + 1, _yearOfConstruction);
            return product;
        }
    }
}
