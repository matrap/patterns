using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.cs
{
    internal class Director : ReportManager
    {
        protected override void WriteRequest(string text)
        {
            Console.WriteLine($"Director manager rejected request for {text}");
        }
    }
}
