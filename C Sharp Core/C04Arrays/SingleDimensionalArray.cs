using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C04Arrays
{
    internal class SingleDimensionalArray
    {
        public static void Main()
        {
            //Default array with new keyword
            int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
            arr1[3] = 4;
            arr1[4] = 5;

            //Initialized array with new keyword
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

            // Initialized array with {}
            int[] arr3 = { 1, 2, 3, 4, 5 };

            // Intialized array with collection expression[]
            int[] arr4 = [1, 2, 3, 4, 5];

            ArrayAccessing(arr1);

            //Nullable type Array
            int?[] arr5 = { 1, null, 3, 4, 5 };
            Console.WriteLine(arr5.Length); // 5
            Console.WriteLine(string.Join(" ", arr5)); // 1, , 3, 4, 5

            // Tuple Array
            (string, int)[] mobiles = [("Apple", 4), ("Samsung", 12), ("Oppo", 8)];
            Console.WriteLine(mobiles.Length); // 3
            Console.WriteLine(string.Join(", ", mobiles)); // (Apple, 4), (Samsung, 12), (Oppo, 8)

            foreach (var mobile in mobiles)
            {
                Console.WriteLine($"brand : {mobile.Item1}, quantity : {mobile.Item2}");
            }
        }

        public static void ArrayAccessing(int[] arr1)
        {
            Console.WriteLine($"arr1 : {arr1}"); // Prints Reference
            Console.WriteLine($"arr1 : {arr1.ToString()}"); // Prints Reference
            Console.WriteLine($"arr1 : {arr1.Length}"); // Prints size

            Console.WriteLine($"arr1 : [ {string.Join(", ", arr1)} ]"); // Prints ELements

            // forward accessing
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]); // 1 2 3 4 5
            }

            // Reverse Order accessing
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr1[i]); // 5 4 3 2 1
            }

            // Reverse Order accessing with ^
            for (int i = 1; i <= arr1.Length; i++)
            {
                Console.WriteLine(arr1[^i]); // 5 4 3 2 1
            }
        }
    }
}
