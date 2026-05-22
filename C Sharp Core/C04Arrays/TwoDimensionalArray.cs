using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C04Arrays
{
    internal class TwoDimensionalArray
    {
        public static void Main()
        {
            //Default array with new keyword
            int[][] arr1 = new int[2][];
            arr1[0] = [1, 2, 3];
            arr1[1] = [4, 5, 6];

            int[][] arr2 = [[1, 2, 3], [4, 5, 6]];

            Console.WriteLine($"arr1 : {arr1}");
            Console.WriteLine($"arr1 : {arr1.Length}");

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + ", ");
                }
            }
            Console.WriteLine();
            foreach (var arr in arr1)
            {
                foreach(var num in arr)
                {
                    Console.WriteLine(num);
                }
            }

        }
        public static void Matrix()
        {
            //Default array with new keyword
            int[,] arr1 = new int[2, 3];
            arr1[0, 0] = 1;
            arr1[0, 1] = 2;
            arr1[0, 2] = 3;
            arr1[1, 0] = 4;
            arr1[1, 1] = 5;
            arr1[1, 2] = 6;

            Console.WriteLine($"arr1 : {arr1}");
            Console.WriteLine($"arr1 : {arr1.Length}");
            Console.WriteLine($"arr1 : {arr1.GetLength(0)}");
            Console.WriteLine($"arr1 : {arr1.GetLength(1)}");

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + ", ");
                }
            }
            Console.WriteLine();
            foreach (int x in arr1)
            {
                Console.WriteLine(x);
            }

        }
    }
}
