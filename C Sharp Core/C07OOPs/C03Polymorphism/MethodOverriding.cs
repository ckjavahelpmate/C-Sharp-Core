using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C07OOPs.C03Polymorphism
{
    internal class MethodOverriding
    {
        public static void Main()
        {
            Parent child = new Child();
            child.Eat(); // Child Eat -> Method overriding
            child.Dance(); // Parent dance -> Method hiding

        }
    }

    public class Parent
    {
        public virtual void Eat()
        {
            Console.WriteLine("parent Eat()");
        }
        public void Dance()
        {
            Console.WriteLine("parent Dance()");
        }
    }

    public class Child : Parent
    {
        public sealed override void Eat()
        {
            Console.WriteLine("Child Eat()");
        }
        public new void Dance()
        {
            Console.WriteLine("Child Dance()");
        }
    }


}
