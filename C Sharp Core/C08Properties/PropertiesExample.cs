using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C08Properties
{
    internal class PropertiesExample
    {
        public static void Main()
        {
            Employee e1 = new Employee()
            {
                Name = "Allen",
                Age = 24,
                Phone = 5566,
                Salary = 2500.00m

            };

            Console.WriteLine($"Employee id : {e1.Id}");
            Console.WriteLine($"Employee Name : {e1.Name}");
            Console.WriteLine($"Employee Age : {e1.Age}");
            //Console.WriteLine($"Employee phone : {e1.Phone}"); 
            Console.WriteLine($"Employee salary : {e1.Salary}");
        }

    }

    public class Employee
    {
        //Property with explicit backing field
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        // Auto-Implemented Property
        public int Age { get; set; }


        // read Only property
        public int Id { get { return 101; } }
        public int Id2 { get; } = 202;


        // Write Only property
        private int phone;
        public int Phone { set { phone = value; } }


        // init property -> can be intialized by object intializer but only once
        public decimal Salary { get; init; }


    }
}
    