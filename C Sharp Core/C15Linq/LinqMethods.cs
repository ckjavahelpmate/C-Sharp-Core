using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C15Linq
{
    internal class LinqMethods
    {

        public static void Main()
        {

            Random random = new Random();
            List<int> list = Enumerable.Range(1, 6)
                .Select(num => random.Next(10, 100))
                .ToList();
            Console.WriteLine($"[ {string.Join(", ", list)} ]");


            // Even Numbers
            var evens = list.Where(num => num % 2 == 0);
            Console.WriteLine($"[ {string.Join(", ", evens)} ]");

            // Sort Acending order
            var ascendingSorted = list.Order();
            Console.WriteLine($"[ {string.Join(", ", ascendingSorted)} ]");

            // Sort Descending order
            var descendingSorted = list.OrderDescending();
            Console.WriteLine($"[ {string.Join(", ", descendingSorted)} ]");

            


        }
    }
}
