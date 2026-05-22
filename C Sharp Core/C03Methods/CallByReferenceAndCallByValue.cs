using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C03Methods
{
    public struct Student
    {
        public int Id;
        public string Name;
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Employee
    {
        public int Id;
        public string Name;
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    internal class CallByReferenceAndCallByValue
    {
        public static void Main()
        {
            int id = 101;
            Student std = new Student(101, "Allen");
            Employee emp = new Employee(101, "Allen");

            Console.WriteLine("Before method call\n====================");
            Console.WriteLine($"id : {id}");
            Console.WriteLine($"std name : {std.Name}");
            Console.WriteLine($"emp name : {emp.Name}");

            //Call by value
            //ValueTypeParameter(id);
            //ValueTypeParameter(std);

            //Call by reference
            ValueTypeParameter(ref id);
            ValueTypeParameter(ref std);
            ValueTypeParameter(emp);

            Console.WriteLine("\nAfter method call\n====================");
            Console.WriteLine($"id : {id}");
            Console.WriteLine($"std name : {std.Name}");
            Console.WriteLine($"emp name : {emp.Name}");
        }

        // Value type parameter
        public static void ValueTypeParameter(int id)
        {
            id = 888;
        }
        public static void ValueTypeParameter(Student std)
        {
            std.Name = "Test Student";
        }

        // Reference type parameter
        public static void ValueTypeParameter(ref int id)
        {
            id = 888;
        }
        public static void ValueTypeParameter(ref Student std)
        {
            std.Name = "Test Student";
        }
        public static void ValueTypeParameter(Employee emp)
        {
            emp.Name = "Test Employee";
        }
    }
}
