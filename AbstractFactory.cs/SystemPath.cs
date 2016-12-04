using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.cs
{
    public class SystemPath
    {
        public string Path { get; private set; }

        public SystemPath(string path)
        {
            Path = path;
        }
    }
}
