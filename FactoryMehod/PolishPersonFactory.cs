using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PolishPersonFactory : PersonFactory
    {
        private Random _random;
        private double _womanProbability;
        protected override IPerson SetRandomName()
        {
            double randomNumber = _random.NextDouble();
            var nameIndex = ((int)(_random.NextDouble() * 100));
            if (randomNumber < _womanProbability)
            {
                return new Woman(nameIndex);
            }   
            else
            {
                return new Man(nameIndex);
            }
        }

        public PolishPersonFactory(double womanProbability)
        {
            _womanProbability = womanProbability;
            _random = new Random();
        }
    }
}
