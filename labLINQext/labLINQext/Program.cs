using System;
using System.Linq;

namespace labLINQext
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "Москва", "Сочи", "Орел", "Самара", "Смоленск", "Ялта" };

            var x1 = arr.Where(v => v.StartsWith("С")).Where(v => v.Length > 5).OrderBy(v => v).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, x1));
            Console.WriteLine();


            var x2 = arr.OrderBy(v => v).Select(v => $"{v} - {v.Contains('а')}").ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, x2));

        }
    }
}
