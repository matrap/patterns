using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StandardCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
