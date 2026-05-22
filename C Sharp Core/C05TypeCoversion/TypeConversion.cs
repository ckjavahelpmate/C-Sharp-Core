using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C05TypeCoversion
{
    internal class TypeConversion
    {
        public static void Main()
        {
            // Implicit Conversion
            int intValue = 10;

            double doubleValue = intValue;
            Console.WriteLine($"doubleValue : {doubleValue}"); // 10
            Console.WriteLine($"doubleValue : {doubleValue.ToString("0.0")}"); //10.0

            decimal decimalValue = intValue;
            Console.WriteLine($"DeciamlValue : {decimalValue}"); //10
            Console.WriteLine($"DeciamlValue : {decimalValue.ToString("0.0")}"); //10.0


            //Explicit Conversion
            double a = 24.5;

            int b = (int)a;
            Console.WriteLine($"a : {b}"); // 24

            decimal c = (decimal)a;
            Console.WriteLine($"c : {c}"); //24.5


            // Parsing
            string s = "123";

            int num1 = int.Parse( s );
            Console.WriteLine( num1); // 123

            string s2 = "123.6";
            double num2 = double.Parse( s2 );
            Console.WriteLine( num2 ); //123.6

            decimal num3 = decimal.Parse( s2 );
            Console.WriteLine( num3 ); // 123.6

            string s3 = "true";
            string s4 = "false";
            string s5 = "abcd";

            bool boolValue = bool.Parse( s3 );
            Console.WriteLine( boolValue );

            bool boolValue2 = bool.Parse( s4 );
            Console.WriteLine( boolValue2 );



            //NumberFormatExcetion
            //int num = int.Parse(s2);
            //bool boolValue3 = bool.Parse( s5 );


            // Parsing with Convert class
            string str = "101";
            int n1 = Convert.ToInt32( str );
            Console.WriteLine( n1 );

            //Parsing with TryParse to avoid exceptions -> for valid returns value for invalid returns default value
            string ss = "101";
            int.TryParse(ss, out int v1);
            Console.WriteLine( v1 ); // 101


            string ss2 = "101.5";
            int.TryParse(ss2, out int v2);
            Console.WriteLine( v2 ); // 0


            // ClassCasting ( is -> to check Object type :: as -> to downcast safely )
            object obj = "c#";

            if (obj is int)
            {
                int num = (int)obj;
                Console.WriteLine(num);
            }
            else if (obj is string)
            {
                string sr = obj as string;
                Console.WriteLine($"{sr} size is {sr.Length}");
            }


        }
    }
}
