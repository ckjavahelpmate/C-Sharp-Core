using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C13Collection
{
    internal class DictionaryExample
    {

        public static void Main()
        {
            Dictionary<string, int> mobiles = [];

            //Adding
            mobiles.Add("Apple", 4);
            mobiles.Add("Samsung", 12);
            mobiles.Add("Oppo", 8);
            mobiles.Add("Vivo", 6);

            foreach (KeyValuePair<string, int> item in mobiles)
            {
                Console.WriteLine( $"{item.Key}:{item.Value}");
            }

        }
    }

}
