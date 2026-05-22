using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C03Methods
{
    internal class TypesOfParameters
    {
        public static void Main()
        {
            OptionalParameters(10); // 10 
            OptionalParameters(10, 20); // 30
            OptionalParameters(10, 20, 30); // 60

            ParameterArray(10, 20);
            ParameterArray(10, 20, 30, 40);

            NamedParameter(id: 101, name: "Allen", salary: 25000.00);
            NamedParameter(id: 101, salary: 25000.00, name:"Smith");
        }
        public static void OptionalParameters(int a=0, int  b=0, int c=0)
        {
            Console.WriteLine($"Result : {a+b+c}");
        }
        public static void ParameterArray(params int[] numbers)
        {
            var sum = 0;
            foreach( var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"sum : {sum}");
        }
        public static void NamedParameter(int id, string name, double salary)
        {
            Console.WriteLine($"id : {id}");
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"salary : {salary}");
            Console.WriteLine("====================");
        }
    }
}
