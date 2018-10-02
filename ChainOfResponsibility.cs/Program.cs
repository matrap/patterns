using System;

namespace ChainOfResponsibility.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportManager lineManager = new LineManager();
            ReportManager hrManager = lineManager.SetSuccessor(new HrManager());
            ReportManager director = hrManager.SetSuccessor(new Director());

            var marek = new Employee(lineManager, "Marek");
            marek.RequestFor("New mobile phone");
        }
    }
}
