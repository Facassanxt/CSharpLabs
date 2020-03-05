using System;
using System.Collections;

namespace labStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack x = new Stack();
            x.Push("Ryazan");
            x.Push(123);
            x.Push("Tyla");
            Console.WriteLine(x.Peek());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());

            #region try-catch-pop
            try
            {
                Console.WriteLine(x.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error " + ex.Message);
            }
            #endregion
        }
    }
}
