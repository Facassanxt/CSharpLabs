using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");

            //(1)
            var t1 = new Task(MyTask1);
            t1.Start(); 
            t1.Wait(); // ждать
                       // t1.Status = TaskStatus.

            // (2)
            new Task(() => Console.WriteLine("Task2")).Start();

            // (3)
            Task.Run(() => Console.WriteLine("Task3"));

            // async await

            Task.Run(async () => { await Task.Delay(100); Console.WriteLine("Task100"); });

            Console.WriteLine("the end");
            Console.ReadKey();
        }

        private static void MyTask1()
        {
            Console.WriteLine("MyTask1");
        }
    }
}
