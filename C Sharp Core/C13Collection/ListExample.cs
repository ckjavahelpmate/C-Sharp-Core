using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C13Collection
{
    internal class ListExample
    {
        public static void Main()
        {
            // List with new keyword
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(string.Join(", ", list));

            List<int> list2 = new List<int> { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", list));

            int[] arr = { 1, 2, 3 };
            List<int> list3 = new List<int>(arr);
            Console.WriteLine(string.Join(", ", list3));

            List<int> list4 = new() { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", list4));


            // List without new keyword
            List<int> list5 = [1, 2, 3, 4];
            Console.WriteLine(string.Join(", ", list5));

            List<int> nums = [];
            // Adding
            nums.Add(50);
            nums.Add(10);
            nums.Add(40);
            nums.Add(30);
            nums.Add(20);
            Console.WriteLine(string.Join(", ", nums));

            //Search
            Console.WriteLine(nums.Contains(40));
            Console.WriteLine(nums.Contains(888));

            // find index
            Console.WriteLine( nums.IndexOf(40));
            Console.WriteLine( nums.IndexOf(888));

            //Remove
            nums.Remove(40);
            Console.WriteLine( string.Join(", ", nums));

            nums.RemoveAt(1);
            Console.WriteLine(string.Join(", ", nums));

            // sort
            nums.Sort();
            Console.WriteLine(string.Join(", ", nums));

            //Reverse
            nums.Reverse();
            Console.WriteLine(string.Join(", ", nums));

            // Convert to array
            int[] array = nums.ToArray();
            Console.WriteLine(string.Join(", ", array));

        }
    }
}
