using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.cs
{
    internal abstract class ReportManager
    {
        protected ReportManager Successor;

        public void Request(string text)
        {
            WriteRequest(text);
        }

        public ReportManager SetSuccessor(ReportManager successor)
        {
            Successor = successor;
            return successor;
        }

        protected abstract void WriteRequest(string text);
    }
}
