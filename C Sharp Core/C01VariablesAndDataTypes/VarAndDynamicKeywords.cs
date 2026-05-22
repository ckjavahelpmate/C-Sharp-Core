using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C01VariablesAndDataTypes
{
    internal class VarAndDynamicKeywords
    {
        static void Main()
        {
            var a = 10;           // int (fixed at compile time)
            dynamic b = 10;       // dynamic (resolved at runtime)

            Console.WriteLine(a + 5);
            Console.WriteLine(b + 5);

            b = "Hello";
            Console.WriteLine(b.Length); // works now
        }
    }
}
