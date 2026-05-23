using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Core.C12Thread
{
    internal class TaskAsyncAwaitExample
    {

        public static async Task Main()
        {
            Task task = MethodA();
             
            MethodB();

            task.Wait();
        }

        public static async Task MethodA()
        {
            Console.WriteLine("MethodA Started");
            await Task.Delay(3000);

            Console.WriteLine("MethodA ended");
        }
        public static async Task MethodB()
        {
            Console.WriteLine("MethodB Started");
            await Task.Delay(2000);
            Console.WriteLine("MethodB ended");
        }
        public static void TaskExample()
        {
            Console.WriteLine("Main Started");
            Task.Run(() =>
            {
                Console.WriteLine("Task completed");
            });

            Console.WriteLine("Main ended");
        }
    }
}
