using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C11String
{
    internal class StringComparision
    {
        public static void Main()
        {

            // String comparision
            string str1 = "Hello";
            string str2 = "Hello";
            Console.WriteLine("str1 : "+ str1 );
            Console.WriteLine("str2 : "+ str2 );

            Console.WriteLine( str1 ==  str2 );                        // true ( value )
            Console.WriteLine( str1.Equals(str2) );                    // true ( value )
            Console.WriteLine( Object.ReferenceEquals( str1, str2) ); // true ( refference )
             
            string str3 = "AAAA"; 
            string str4 = new string('A', 4); // AAAA
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine("str4 : " + str4);

            Console.WriteLine(str3 == str4);                        // true ( value )
            Console.WriteLine(str3.Equals(str4));                   // true ( value )
            Console.WriteLine(Object.ReferenceEquals(str3, str4)); // false ( refference )

            Console.WriteLine("=======================================================================");

            // StringBuilder comparision
            StringBuilder sb1 = new StringBuilder("Hello");
            StringBuilder sb2 = new StringBuilder("Hello");
            Console.WriteLine("sb1 : " + sb1);
            Console.WriteLine("sb2 : " + sb2);
            Console.WriteLine(sb1 == sb2);                        // false ( refference )
            Console.WriteLine(sb1.Equals(sb2));                   // True ( refference )
            Console.WriteLine(Object.ReferenceEquals(sb1, sb2)); // false ( refference )
        }
    }
}
