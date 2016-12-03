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
            Client client = new Client();
            string peugeotParams = client.BuyPeugeot().ToString();
            Console.WriteLine(peugeotParams);
            string skodaParams = client.BuySkoda().ToString();
            Console.WriteLine(skodaParams);
        }
    }
}
