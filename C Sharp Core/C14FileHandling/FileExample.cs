using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C14FileHandling
{
    internal class FileExample
    {

        public static void Main()
        {
            var projectRoot = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!;

            // Write to text file
            string[] data =
                [
                    "Hello",
                    "Bangalore",
                    "How are you" ,
                    ""
                ];
            //File.WriteAllLines(projectRoot + "\\data.txt", data);
            File.AppendAllLines(projectRoot + "\\data.txt", data);


            // Read from text file
            string[] lines = File.ReadAllLines(projectRoot + "\\data.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }



        }
    }
}
