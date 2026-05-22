using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C10Delegate
{
    internal class GenericBuiltInDelegates
    {
        public static void Main()
        {
            // Action : void
            Action<int, int> action = (x, y) =>
            {
                Console.WriteLine($"Result of {x}+{y}={x + y}");
            };
            action(1, 2); // 3
            action(2, 3); // 5



            // Func : <T>
            Func<int, int, int> func = (x, y) =>
            {
                return x + y;
            };
            Console.WriteLine(func(2, 3)); // 5
            Console.WriteLine(func(24, 3)); // 27


            // Predicate : bool
            Predicate<int> predicate = (x) =>
            {
                return x % 2 == 0;
            };
            Console.WriteLine( predicate(34) );
            Console.WriteLine( predicate(33) );


        }
    }
}
