using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C01VariablesAndDataTypes
{
    internal class TupleExamples
    {
        public static void Main()
        {
            // Tuple with multiple values
            var empDetails = (101, "Allen", 2500.00);
            Console.WriteLine($"emp id : {empDetails.Item1}");
            Console.WriteLine($"emp name : {empDetails.Item2}");
            Console.WriteLine($"emp salaru : {empDetails.Item3}");

            //Tuple with names
            var stdDetails = (id: 202, name: "Sheela", marks: 84.57);
            Console.WriteLine($"emp id : {stdDetails.id} ");
            Console.WriteLine($"emp name : {stdDetails.name} ");
            Console.WriteLine($"emp salary : {stdDetails.marks} ");

            var (id, name, salary) = (202, "Sheela", 2000.00);
            Console.WriteLine($"emp id : {id} ");
            Console.WriteLine($"emp name : {name} ");
            Console.WriteLine($"emp salary : {salary} ");

            var (empId, empName, empSalary) = (eId: 202, eName: "Sheela", eSalary: 2000.00); // right side names are replaced by leftside names
            Console.WriteLine($"emp id : {empId} ");
            Console.WriteLine($"emp name : {empName} ");
            Console.WriteLine($"emp salary : {empSalary} ");

            // Nested tuple
            var carDetails = (carId: 111, carColor: "Red", carPrice: 7500000.00, engineDetails:(engineId: 333, engineCc: 2.5));
            Console.WriteLine($"car id : {carDetails.carId}");
            Console.WriteLine($"car color : {carDetails.carColor}");
            Console.WriteLine($"car price : {carDetails.carPrice}");
            Console.WriteLine($"engine id : {carDetails.engineDetails.engineId}");
            Console.WriteLine($"engine cc : {carDetails.engineDetails.engineCc}");

            // Tuple returned from methods
            var result = Calculate(5, 5);
            Console.WriteLine($"sum : {result.sum}");
            Console.WriteLine($"product : {result.product}");

            var (sum, product) = Calculate(5, 5);
            Console.WriteLine($"sum : {sum}");
            Console.WriteLine($"product : {product}");

            var std = GetStudent();
            Console.WriteLine($"id : {std.Item1}");
            Console.WriteLine($"name : {std.Item1}");

            var (sid, sname) = GetStudent();
            Console.WriteLine($"id : {sid}");
            Console.WriteLine($"name : {sname}");


            // Tuple Array
            (string, int)[] mobiles = [("Apple", 4), ("Samsung", 12), ("Oppo", 8)];
            Console.WriteLine( mobiles.Length ); // 3
            Console.WriteLine(string.Join(", ", mobiles)); // (Apple, 4), (Samsung, 12), (Oppo, 8)

            foreach( var mobile in mobiles)
            {
                Console.WriteLine($"brand : {mobile.Item1}, quantity : {mobile.Item2}");
            }

            // Tuple List
            List<(string, int)> mobiles2 = [("Apple", 4), ("Samsung", 12), ("Oppo", 8)];


        }

        static (int sum, int product) Calculate(int a, int b)
        {
            return (a + b, a * b);
        }
        static (int, string) GetStudent()
        {
            return (999, "miller");
        }

    }
}
