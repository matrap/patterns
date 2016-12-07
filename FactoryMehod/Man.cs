using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Man : IPerson
    {
        private string[] _names = { "Edward", "Zbigniew", "Piotr", "Kazimierz" };

        public string Name { get; private set; }

        public Man(int nameIndex)
        {
            Name = _names[nameIndex % _names.Length];
        }
    }
}
