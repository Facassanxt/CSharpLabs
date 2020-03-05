using System;
using System.Collections;
using System.Collections.Generic;

namespace Queuee
{
    class Program 
    {
        static void Main(string[] args)
        {
            GenericList<int> tt = new GenericList<int>();
            Queue queue = new Queue();
            queue.Enqueue(6);
            queue.Enqueue(4);
            queue.Enqueue("rtgrtgtrt");
            queue.Enqueue(5);

            Console.WriteLine(queue.Peek());
            Console.WriteLine("-----");

            tt.print(queue);

            Console.ReadLine();
        }
    }
}

public class GenericList<T>
{
    public void print(Queue input) {
        while (input.Count > 0 )
        {
            Console.WriteLine(input.Dequeue());
        }
    }
}
