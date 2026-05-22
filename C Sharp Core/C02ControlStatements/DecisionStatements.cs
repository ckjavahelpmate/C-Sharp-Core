using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C02ControlStatements
{
    internal class DecisionStatements
    {

        public static void Main()
        {
            IsEven(25);
            GetAbsoluteNumber(23);
            GetAbsoluteNumber(-23);

            CharCheck('A');
            CharCheck('f');
            CharCheck('5');
            CharCheck('*');
        }

        public static void CharCheck(char ch)
        {
            if (Char.IsUpper(ch))
            {
                Console.WriteLine($"{ch} is Upper case alphabet");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine($"{ch} is Lower case alphabet");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"{ch} is Digit");
            }
            else
            {
                Console.WriteLine($"{ch} is Special character");
            }
        }
        public static void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even number");
            }
            else
            {
                Console.WriteLine($"{num} is not even number");
            }
        }

        public static void GetAbsoluteNumber(int num)
        {
            if (num < 0)
            {
                num = num * (-1);
            }
            Console.WriteLine($"num : {num}");
        }
    }


}
