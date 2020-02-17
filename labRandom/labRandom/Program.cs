using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(value: rnd.Next(100));
            Console.WriteLine();

            byte[] x = new byte[15];
            rnd.NextBytes(x);
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i]);
            Console.ReadKey();

        }
    }
}
