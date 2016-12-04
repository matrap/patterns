using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = "Users";
            string subDirectory = "Gregory";
            IPathFactory linuxFactory = new LinuxPathFactory();
            SystemPath linuxPath = linuxFactory.GetPath(directory, subDirectory);
            Console.WriteLine("Linux: " + linuxPath.Path);
            IPathFactory windowsFactory = new WindowsPathFactory();
            SystemPath windowsPath = windowsFactory.GetPath(directory, subDirectory);
            Console.WriteLine("Windows: " + windowsPath.Path);
            
        }
    }
}
