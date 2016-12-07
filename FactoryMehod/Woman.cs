using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Woman : IPerson
    {
        private string[] _names = { "Katarzyna", "Amelia", "Kinga" };

        public string Name { get; private set; }

        public Woman(int nameIndex)
        {
            Name = _names[nameIndex % _names.Length];
        }
    }
}
