using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PolishPersonFactory(0.4);
            for(int i=0; i<100; i++)
            {
                IPerson person = factory.GetPerson();
                Console.WriteLine(person.Name);
            }
        }
    }
}
