using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    public interface IPathFactory
    {
        SystemPath GetPath(string directory, string subDirectory);
    }
}
