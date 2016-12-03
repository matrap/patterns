using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public interface ICar
    {
        double EngineVolume { get; }
        int DoorsNumber { get; }
        int YearOfConstruction { get; }

        string ToString();
    }
}
