using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.cs
{
    internal class Employee
    {
        public string FullName { get; }
        private readonly ReportManager _reportManager;

        public Employee(ReportManager reportManager, string fullName)
        {
            _reportManager = reportManager;
            FullName = fullName;
        }

        public void RequestFor(string text)
        {
            Console.WriteLine($"{FullName} requested for {text}");
            _reportManager.Request(text);
        }
    }
}
