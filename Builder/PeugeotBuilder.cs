using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PeugeotBuilder
    {
        private double _engineVolume;
        private int _doors;
        private int _yearOfConstruction;

        public PeugeotBuilder InputEngine(double volume)
        {
            _engineVolume = volume;
            return this;
        }

        public PeugeotBuilder AddDoor(int number)
        {
            _doors = _doors + number;
            return this;
        }

        public PeugeotBuilder TakeFromConstructionYear(int year)
        {
            _yearOfConstruction = year;
            return this;
        }

        public Peugeot Build()
        {
            Peugeot product = new Peugeot(_engineVolume, _doors, _yearOfConstruction);
            return product;
        }
    }
}
