using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class PersonFactory
    {
        protected abstract IPerson SetRandomName();

        public IPerson GetPerson()
        {
            return SetRandomName();
        }
    }
}
