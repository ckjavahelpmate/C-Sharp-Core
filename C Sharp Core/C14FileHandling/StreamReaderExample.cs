using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C14FileHandling
{
    internal class StreamReaderAndWriterExample
    {
        public static void Main()
        {
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(AppContext.BaseDirectory);
            string projectRoot = Directory.GetParent(AppContext.BaseDirectory)!
             .Parent!
             .Parent!
             .Parent!
             .FullName;

            Console.WriteLine(projectRoot);

            // Write data into text file
            StreamWriter writer = new StreamWriter(projectRoot + "\\data.txt", append: true);
            writer.WriteLine("Hello C#");
            writer.WriteLine("Writing file using StreamWriter");
            writer.WriteLine("Line 3");
            writer.WriteLine();
            writer.Close();


            // Read data from text file 
            StreamReader sr = new StreamReader(projectRoot + "\\data.txt");

            //string content = sr.ReadToEnd();
            //Console.WriteLine(content);


            while( !sr.EndOfStream )
            {
                Console.WriteLine( sr.ReadLine() );
            }


            sr.Close();



        }
    }
}
