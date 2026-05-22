using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C01VariablesAndDataTypes
{
    internal class Nullabletypes
    {
        public static void Main()
        {
            // ? (nullable type) -> make it nullable
            int? age = null;
            Console.WriteLine(age);

            if (age.HasValue)
            {
                Console.WriteLine(age.Value); 
            }
            else
            {
                Console.WriteLine("No value");
            }
            if (age != null)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("No value");
            }


            //?? (null - coalescing operator) -> Provides a default value when null
            string name = null;
            string result = name ?? "Guest";
            Console.WriteLine(result);

            string user1 = null;
            string user2 = null;
            string res = user1 ?? user2 ?? "Anonymous";
            Console.WriteLine(res);

            //!(null - forgiving operator) -> "I know this is not null — trust me"
            string? input = null;
            string username = input ?? "Guest";
            Console.WriteLine(username!.Length);


            //Nullable type Array
            int?[] arr5 = { 1, null, 3, 4, 5 };

            Console.WriteLine(arr5.Length); // 5
            Console.WriteLine(string.Join(" ", arr5)); // 1, , 3, 4, 5

            

        }
    }
}
