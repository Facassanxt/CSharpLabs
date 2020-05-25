using System;

namespace labTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var x0 = 5;
            int x00 = 5;

            var x1 = (2, 4);
            (int, int) x11 = (2, 4);
            Console.WriteLine(x1.Item1);
            Console.WriteLine(x1.Item2);
            Console.WriteLine(x11);


            (int min, int max) x2 = (2, 4);
            Console.WriteLine(x2.min);
            Console.WriteLine(x2.max);
            Console.WriteLine();


            var x3 = (min: 2, max: 4);
            Console.WriteLine(x3.min);
            Console.WriteLine(x3.max);
            Console.WriteLine();



            var (min, max) = (2, 4);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine();


            var x5 = GetX5();
            Console.WriteLine(x5.Item1);
            Console.WriteLine(x5.Item2);
            Console.WriteLine();


            var x6 = GetX6();
            Console.WriteLine(x6.min);
            Console.WriteLine(x6.max);
            Console.WriteLine();



            var x7 = GetX7((4,5),6);
            Console.WriteLine(x7.Item1);
            Console.WriteLine(x7.Item2);
            Console.WriteLine();

        }


        private static (int, int) GetX7((int, int) p, int v) => (p.Item1 + p.Item1, v);
        //private static (int, int) GetX7((int, int) p, int v)
        //{
        //    return (p.Item1 + p.Item1, v);
        //}

        private static (int min, int max) GetX6()
        {
            return (3, 6);
        }

        private static (int, int) GetX5()
        {
            return (3, 6);
        }
    }
}
