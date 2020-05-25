using System;
using System.Linq;

namespace labLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var arrq = Enumerable.Range(0, 10).ToArray();
            var myQuery =
                from v in arrq
                where v > 5 && v < 8
                orderby v descending
                select v;
            Console.WriteLine(string.Join(" ", arrq));
            Console.WriteLine(string.Join(" ", myQuery));
            Console.WriteLine($"Count= {myQuery.Count()}, Sum= {myQuery.Sum()}");


            Console.WriteLine("---------------------------");

            var arr2 = new string[] { "Юра", "Миша", "Сергей", "Игорь", "Максим", "майкл" };
            var myQuery2 =
               from v in arr2
               where v.ToUpper().StartsWith('М')
               select $"<{v.ToLower()}>";
            Console.WriteLine(string.Join(" ", myQuery2));
        }
    }
}
