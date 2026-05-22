using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C06UsingStatement.Runner
{
    internal class App2
    {
        public static void Main()
        {
            Console.WriteLine("App2 started");

            // Calculator not imported locally because its imported globally in GlobalUsing.cs file
            Calculator calculator = new Calculator();
            calculator.Add(10, 15); // 25
            calculator.Sub(25, 3); // 22

            Calculator.Power(2, 3); // 8

            Console.WriteLine("App2 Ended");
        }
    }
}
