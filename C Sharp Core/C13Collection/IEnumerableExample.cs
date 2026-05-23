using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C13Collection
{
    internal class IEnumerableExample
    {
        public static void Main()
        {
            IEnumerable<int> nums = new List<int>() { 1, 2, 3 };
            IEnumerable<int> nums2 = [1, 2, 3];
            foreach (int num in nums)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            // IEnumerable vs Enumerator
            List<int> ints = [1, 2, 3, 4, 5];
            IEnumerator<int> e = ints.GetEnumerator();

            while (e.MoveNext())
            {
                Console.Write(e.Current + ", ");
            }
            Console.WriteLine();

            // Enumerable methods
            var numbers = Enumerable.Range(0, 10);
            foreach (int num in numbers)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            // Even number from 1 to 10 ;
            var evens = Enumerable.Range(0, 10).Where(num => num % 2 == 0);
            foreach (int num in evens)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();


            // even*10 and odd*100 from 1 to 10
            var res = Enumerable.Range(1, 10)
                .Select(num =>
                {
                    if (num % 2 == 0)
                        return num * 10;
                    else
                        return num * 100;
                });
            foreach (int num in res)
            {
                Console.WriteLine(num);
            }


        }
    }
}
