using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имя?");
            string x = Console.ReadLine();
            Console.Write("Фамилия?");
            string y = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("[" + i + "] ");
                Console.WriteLine("Привет, {0}{1}!", x, y);
            }

            Console.ReadKey();
        }
    }
}
