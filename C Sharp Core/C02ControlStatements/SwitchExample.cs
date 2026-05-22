using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C02ControlStatements
{
    internal class SwitchExample
    {
        public static void Main()
        {
            GetDayOfWeek(1);
            GetDayOfWeek(5);
            GetDayOfWeek(7);
        }

        // Regular switch expression
        public static void GetDayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday"); break;
                case 2:
                    Console.WriteLine("Tuesday"); break;
                case 3:
                    Console.WriteLine("Wednesday"); break;
                case 4:
                    Console.WriteLine("Thursday"); break;
                case 5:
                    Console.WriteLine("Friday"); return;
                case 6:
                    Console.WriteLine("Saturday"); return;
                case 7 or 0:
                    Console.WriteLine("Sunday"); return;
                default:
                    Console.WriteLine("Invalid day");
                    return;
            }
        }
        // With modern switch exepression
        public static void GetDayOfWeek2(int day)
        {
            string result = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 or 0 => "Sunday",
                _ => "Invalid"
            };

            Console.WriteLine(result);
        }

        // Pattern Matching
        public static void GetGrade(int marks)
        {
            string result = marks switch
            {
                >= 90 => "A",
                >= 75 => "B",
                >= 50 => "C",
                _ => "Fail"
            };

            Console.WriteLine(result);
        }
        public static void GetType(object obj)
        {
            switch (obj)
            {
                case int n:
                    Console.WriteLine($"Integer: {n}");
                    break;

                case string s:
                    Console.WriteLine($"String: {s}");
                    break;
            }
        }

        // switch with when, &&, ||
        public static void IsVowel(char ch)
        {
            switch (ch)
            {
                case char c when c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;
                case char c when char.IsLetter(c):
                    Console.WriteLine($"{ch} is a not Vowel");
                    break;
                default:
                    Console.WriteLine($"{ch} is not alphabet");
                    break;
            }
        }
    }
}
