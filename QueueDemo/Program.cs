using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            System.Console.WriteLine("Queue Peak : {0}", queue.Peek());
            System.Console.WriteLine("Queue Dequeue : {0}", queue.Dequeue());
            System.Console.WriteLine("Queue Peak : {0}", queue.Peek());
        }
    }
}