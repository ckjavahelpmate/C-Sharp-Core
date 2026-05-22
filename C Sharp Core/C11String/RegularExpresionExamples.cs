using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Core.C11String
{
    internal class RegularExpresionExamples
    {

        public static void Main()
        {
            /*        
            Regular expresion basic synatx
            Regex.Method(input, pattern)

            1. IsMatch()	-> check pattern exists
            2. Match()	    -> first match
            3. Matches()	-> all matches
            4. Replace()	-> replace pattern
            5. Split()	    -> split using pattern

            */

            // 1. IsMatch()	-> check pattern exists
            Console.WriteLine(Regex.IsMatch("abc123", "\\d"));  // True



            // 2. Match()	    -> first match
            Match m = Regex.Match("abc123xyz", "[0-9]+");
            Console.WriteLine(m.Value); // 123


            // 3. Matches()	-> all matches
            MatchCollection matches = Regex.Matches("a1b22c333", "[0-9]+");
            foreach (Match ma in matches)
            {
                Console.Write(ma.Value +", "); //1, 22, 333
            }
            Console.WriteLine();

            // 4. Replace()	-> replace pattern
            string result = Regex.Replace("abc123xyz", "[^0-9]", "*");
            Console.WriteLine(result); // abc***xyz


            // 5. Split()	    -> split using pattern
            string str = "12/04-2026";
            string[] arr = Regex.Split(str, "[/-]");
            Console.WriteLine(string.Join(", ", arr));


        }
    }
}

