using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C07OOPs.C02Relationship
{
    internal class InheritanceExample
    {
        public static void Main()
        {

            // Non-static members
            Child child = new Child();
            Console.WriteLine($"child.childId : {child.childId}");
            Console.WriteLine($"child.parentId : {child.parentId}");

            Parent parent = new Parent();
            //Console.WriteLine($"parent.childId : {parent.childId}"); CTE
            Console.WriteLine($"parent.parentId : {parent.parentId}");



            // Static members
            Console.WriteLine($"Child.childName : {Child.childName}");
            Console.WriteLine($"Child.parentName : {Child.parentName}");

            //Console.WriteLine($"Parent.childName : {Parent.childName}"); CTE
            Console.WriteLine($"Parent.parentName : {Parent.parentName}");

        }
    }

    public class Parent
    {
        public int parentId = 101;
        public static string parentName = "Sheela";
    }

    public class Child : Parent
    {
        public int childId = 202;
        public static string childName = "Mala";
    }


}
