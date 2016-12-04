using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Skoda
    {
        public double EngineVolume { get; private set; }
        public int DoorsNumber { get; private set; }
        public int YearOfConstruction { get; private set; }

        public Skoda(double engineVolume, int doors, int yearOfConstruction)
        {
            EngineVolume = engineVolume;
            DoorsNumber = doors;
            YearOfConstruction = yearOfConstruction;
        }

        public override string ToString()
        {
            return string.Format("Skoda engine: {0} TDI, doors: {1}, year: {2}",
                EngineVolume, DoorsNumber, YearOfConstruction);
        }
    }
}
