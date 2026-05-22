using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C01VariablesAndDataTypes
{
    class Employee
    {
        int id;
        string name;
        double salary;
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }

    public interface  IService
    {
        
    }
    internal class ReferenceTypeDataTypes
    {
        public static void Main()
        {
            // String reference type
            string name = "Chethan";

            // Array reference type
            int[] numbers = { 1, 2, 3 };

            // Class reference type
            Employee employee = new Employee(101, "Allen", 25000.00 );

            // Object reference type
            object obj = new object();

            // List reference type
            List<int> list = new List<int>();

            // Interface reference type
            IService service;

            // Delegate reference type
            Action action = () => Console.WriteLine("Hello");
        }
    }
}
