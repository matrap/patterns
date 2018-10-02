using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.cs
{
    internal class LineManager : ReportManager
    {
        protected override void WriteRequest(string text)
        {
            Console.WriteLine($"Line manager accepted request for {text}");
            Successor.Request(text);
        }
    }
}
