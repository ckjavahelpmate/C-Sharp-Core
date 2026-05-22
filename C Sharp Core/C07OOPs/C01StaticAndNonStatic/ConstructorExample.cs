using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C07OOPs.C01StaticAndNonStatic
{
    internal class ConstructorExample
    {

        public static void Main()
        {
            // With No-args
            Demo obj1 = new Demo();

            // WIth args
            Demo demo2 = new Demo(101, "Sheela");

            // Without class name -> LHS datatype should explicitly specified
            Demo obj23 = new();



            // With new & object initializer
            Demo demo4 = new Demo()
            {
                // Properties Initialization
            };

            // Without new & object initializer
            Demo demo5 = new()
            {
                // Properties Initialization
            };




            // Primary constructor
            PrimaryConstructorExample pce = new PrimaryConstructorExample(101, "Mala");
            Console.WriteLine( pce);


        }
    }

    public class PrimaryConstructorExample(int id, string name)
    {
        public override string? ToString()
        {
            return $"[ id : {id}, name : {name} ]";
        }
    }

    public class Demo
    {
        int id;
        string name;
        public Demo() { }
        public Demo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string? ToString()
        {
            return $"[ id : {id}, name : {name} ]";
        }
    }
}
