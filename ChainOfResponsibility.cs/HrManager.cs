using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.cs
{
    internal class HrManager : ReportManager
    {
        protected override void WriteRequest(string text)
        {
            Console.WriteLine($"HR manager accepted request for {text}");
            Successor.Request(text);
        }
    }
}
