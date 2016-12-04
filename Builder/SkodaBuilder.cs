using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class SkodaBuilder
    {
        private double _engineVolume;
        private int _doors;
        private int _yearOfConstruction;

        public SkodaBuilder InputEngine(double volume)
        {
            _engineVolume = volume;
            return this;
        }

        public SkodaBuilder AddDoor(int number)
        {
            _doors = _doors + number;
            return this;
        }

        public SkodaBuilder TakeFromConstructionYear(int year)
        {
            _yearOfConstruction = year;
            return this;
        }

        public Skoda Build()
        {
            Skoda product = new Skoda(_engineVolume, _doors, _yearOfConstruction);
            return product;
        }
    }
}
