using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C12Thread
{
    internal class ThreadExample
    {
        public static void Main()
        {
            Thread.CurrentThread.Name = "Mala";
            //Console.WriteLine( "Thread Name "+ Thread.CurrentThread.Name );

            Thread t1 = new Thread(() =>
            {
                ReadData();
            });

            Thread t2 = new Thread(() =>
            {
                foreach (var num in Enumerable.Range(1, 10))
                {
                    Console.WriteLine("Hello....");
                    Thread.Sleep(3000);
                }
            });

            t1.Start();
            t2.Start();
            
        }

        public static void ReadData()
        {
            Console.WriteLine("Enter Your EMPID");
            int id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Your Name");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter Your Salary");
            decimal salary = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("EMP ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Salary : " + salary);
        }


    }
}
