using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C06UsingStatement.Utility
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Result : { a+b }");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Result : { a-b }");
        }
        public static void Power(int x, int n)
        {
            var temp = n;
            var res = 1;
            while( n > 0 )
            {
                res = res * x;
                n--;
            }
            Console.WriteLine($"Result of {x}^{temp} : { res }");
        }
    }
}
