using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICarBuilder
    {
        ICarBuilder InputEngine(double volume);
        ICarBuilder AddDoor(int number);
        ICarBuilder TakeFromConstructionYear(int year);
        ICar Build();
    }
}
