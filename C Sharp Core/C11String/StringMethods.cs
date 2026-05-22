using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C11String
{
    internal class StringMethods
    {

        public static void Main()
        {
            string str = "Java Class";

            PrintStringCharactersByForLoop(str);

            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            char[] chars = str.ToCharArray();
            Console.WriteLine(chars);

            Console.WriteLine(str.IndexOf('v')); // 2
            Console.WriteLine(str.IndexOf("v")); // 2
            Console.WriteLine(str.IndexOf("x")); // -1

            Console.WriteLine(str.Contains('v')); // true
            Console.WriteLine(str.Contains("v")); // true
            Console.WriteLine(str.Contains("x")); // false

            Console.WriteLine(str.Replace('a', '0'));
            Console.WriteLine(str.Replace("a", "o"));

            Console.WriteLine(str.Substring(2, 2)); // va -> startIndex, length
            Console.WriteLine(str.Substring(5)); // Class -> startIndex

            Console.WriteLine( str.Remove(2) ); //Ja -> startIndex
            Console.WriteLine( str.Remove(2, 1) ); //Jaa Class -> startIndex, count

            string date = "12/04/2026";
            string[] words = date.Split("/");
            Console.WriteLine( string.Join(", ", words) );

        }


        public static void PrintStringCharactersByForEach(string str)
        {
            foreach (var ch in str)
            {
                Console.WriteLine(ch);
            }
        }
        public static void PrintStringCharactersByForLoop(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

    }
}
