using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarProvider carProvider = new CarProvider();
            string peugeotParams = carProvider.ConstructPeugeot(2016).ToString();
            Console.WriteLine(peugeotParams);
            string skodaParams = carProvider.ConstructSkoda(2015).ToString();
            Console.WriteLine(skodaParams);
        }
    }
}
