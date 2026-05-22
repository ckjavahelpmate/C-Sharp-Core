using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C07OOPs.C01StaticAndNonStatic
{
    internal class StaticAndNonStatic
    {
        public static void Main()
        {
            // Stati methods -> can be accessed only by classname
            SameClassStaticMethod();
            DemoClass.DifferentClassStaticMethod();

            //Non-static methods -> accessed only by object reference
            StaticAndNonStatic sameClass = new StaticAndNonStatic();
            sameClass.SameClassNonStaticMethod();

            DemoClass demoClass = new DemoClass();
            demoClass.DifferentClassNonStaticMethod();
        }

        public static void SameClassStaticMethod()
        {
            Console.WriteLine("Same Class Static Method");
        }
        public void SameClassNonStaticMethod()
        {
            Console.WriteLine("Same Class NonStatic Method");
        }
    }
    internal class DemoClass
    {
        public static void DifferentClassStaticMethod()
        {
            Console.WriteLine("Different Class Static Method");
        }
        public void DifferentClassNonStaticMethod()
        {
            Console.WriteLine("Different Class NonStatic Method");
        }


    }


}
