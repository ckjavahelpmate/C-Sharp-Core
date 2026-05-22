using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C10Delegate
{
    class DelegateClass
    {
        public delegate void Calculator(int a, int b);
    }
    internal class DelegateExample
    {
        public static void Main()
        {
            DelegateClass.Calculator calci = Add;
            calci += Sub;

            calci(20, 5);

        }

        public static void Add(int a, int b)
        {
            Console.WriteLine($"{a}+{b} : {a + b}");
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine($"{a}-{b} : {a - b}");
        }

    }
}

// Where you CAN declare a delegate
// 1. inside namespace
namespace Demo
{
    public delegate void MyDelegate();

    // 2. Inside a class
    class Test
    {
        public delegate void MyDelegate();
    }

    // 3.Inside a struct
    struct Sample
    {
        public delegate void MyDelegate();
    }
}


// Where you CANNOT declare a delegate
// 1. Inside a statement block without proper type context
// 2. Inside loops
// 3. Inside property getter/setter
// 4. Inside method
