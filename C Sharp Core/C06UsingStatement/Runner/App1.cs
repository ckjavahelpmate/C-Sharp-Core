
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using as import statement
using C_Sharp_Core.C06UsingStatement.Utility;

namespace C_Sharp_Core.C06UsingStatement.Runner
{
    internal class App1
    {

        public static void Main()
        {
            Console.WriteLine("App1 started");

            Calculator calculator = new Calculator();
            calculator.Add(10, 15); // 25
            calculator.Sub(25, 3); // 22

            Calculator.Power(2, 3); // 8

            Console.WriteLine("App1 Ended");
        }
    }
}
