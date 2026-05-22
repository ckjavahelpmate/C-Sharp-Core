using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C06UsingStatement
{
    internal class UsingStatement
    {
        public static void Main()
        {
            // Using as UsinngStatement -> SUtomatically disposes the object after end of block. only for IDisposable type objects can be used.
            Console.WriteLine("Main Start");
            using (Test t = new Test())
            {
                Console.WriteLine("Test Object create : " + t);
                Console.WriteLine("working....");
            }
            Console.WriteLine("Main End");
        }
        
        // if block not used for UsingStatement then its immediate parent block will be considered
        public static void MOdernStyleUsingStatement()
        {
            Console.WriteLine("Main Start");
            {
                using Test t = new Test();
                Console.WriteLine("Test Object create : " + t);
                Console.WriteLine("working....");
            }
            Console.WriteLine("Main End");
        }
    }

    public class Test : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Object disposed");
        }
    }
}
