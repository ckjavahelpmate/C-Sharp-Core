using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C02ControlStatements
{
    internal class LoopStatements
    {
        public static void Main()
        {
            PrintNumbersInGivenRange(1, 10);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            DisplayElements(numbers);
            
        }

        public static void PrintNumbersInGivenRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void DisplayElements(int[] numbers)
        {
           foreach (int i in numbers)
            {
                Console.Write( i+", " );
            }
        }
    }
}
