using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C01VariablesAndDataTypes
{
    struct Student
    {
        public int id;
        public string name;
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string? ToString()
        {
            return $"[id={id}, name={name}]";
        }
    }
    internal class ValueTypeDataTypes
    {
        public static void Main()
        {
            // Whole number data types
            sbyte byteValue = 101;
            short shortValue = 5566;
            int intValue = 55664488;
            long longValue = 88997755688886;

            // Decimal data types
            float floatValue = 888.12345678987654321f; // 7digit precison
            double doubleValue = 888.12345678987654321; // 16 digit precesion
            decimal decimaValue = 888.123456789987654321123456789m; // 29 digit precesion

            // character data type
            char charValue = 'k';

            //Boolean data type
            bool boolValue = true;

            // Struct data type
            Student studentValue = new Student();
            Student studentValue2 = new Student();
            Console.WriteLine(studentValue.Equals(studentValue2));

            Console.WriteLine("byteValue : " + byteValue);
            Console.WriteLine("shortValue : " + shortValue);
            Console.WriteLine("intValue : " + intValue);
            Console.WriteLine("longValue : " + longValue);
            Console.WriteLine("floatValue : " + floatValue);
            Console.WriteLine("doubleValue : " + doubleValue);
            Console.WriteLine("decimaValue : " + decimaValue);
            Console.WriteLine("charValue : " + charValue);
            Console.WriteLine("boolValue : " + boolValue);
            Console.WriteLine("studentValue : " + studentValue);





        }
    }
}
