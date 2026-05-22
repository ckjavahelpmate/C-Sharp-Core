using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C07OOPs.C01StaticAndNonStatic
{
    internal class ConstructorChaining
    {
        public static void Main()
        {
            new Child(10);
        }
    }

    public class Grandparent
    {
        public Grandparent() : this(23)
        {
            Console.WriteLine("Grandparent()");
        }
        public Grandparent(int num) 
        {
            Console.WriteLine("Grandparent(int num)");
        }
    }
    public class Parent : Grandparent 
    {
        public Parent() : base() 
        {
            Console.WriteLine("Parent()");
        }
        public Parent(int num) 
        {
            Console.WriteLine("Parent(int num)");
        }
    }
    public class Child : Parent 
    {
        public Child() 
        {
            Console.WriteLine("Child()");
        }
        public Child(int num) : this()
        {
            Console.WriteLine("Child(int num)");
        }
    }
}
