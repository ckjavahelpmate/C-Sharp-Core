using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C13Collection
{
    internal class LinkedListExample
    {

        public static void Main()
        {
            LinkedList<int> ll = new LinkedList<int>();

            //Adding
            ll.AddLast(50);
            ll.AddLast(10);
            ll.AddLast(40);
            ll.AddLast(20);
            ll.AddLast(30);
            Console.WriteLine( string.Join(", ", ll) ) ;


            ll.AddFirst(888);
            Console.WriteLine(string.Join(", ", ll));


            //Serach
            Console.WriteLine( ll.Contains(40) );


            //Remove
            ll.Remove(40);
            Console.WriteLine(string.Join(", ", ll));

            ll.RemoveFirst();
            Console.WriteLine(string.Join(", ", ll));

            ll.RemoveLast();
            Console.WriteLine(string.Join(", ", ll));




        }
    }
}
