using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C01VariablesAndDataTypes
{
    class ApplicationSettings
    {
        // const → compile-time constant
        public const double Pi = 3.14159;

        // readonly → runtime constant
        public readonly DateTime CreatedDate;

        // readonly value can be assigned in constructor
        public ApplicationSettings()
        {
            CreatedDate = DateTime.Now;
        }
    }   
    internal class ConstVsReadonly
    {
        static void Main()
        {
            // Access const directly using class name
            Console.WriteLine(ApplicationSettings.Pi);

            ApplicationSettings settings = new ApplicationSettings();

            // Access readonly through object
            Console.WriteLine(settings.CreatedDate);

            // Try to modfy the object
            //ApplicationSettings.Pi = 455; // CTE
            //settings.CreatedDate = DateTime.Now; //CTE
        }
    }
}
