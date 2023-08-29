// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Deque<T>
{
    private LinkedList<T> items = new LinkedList<T>();

    public void EnqueueFront(T item)
    {
        items.AddFirst(item);
    }

    public void EnqueueRear(T item)
    {
        items.AddLast(item);
    }

    public T DequeueFront()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Deque is empty.");

        T item = items.First.Value;
        items.RemoveFirst();
        return item;
    }

    public T DequeueRear()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("Deque is empty.");

        T item = items.Last.Value;
        items.RemoveLast();
        return item;
    }

    public int Count
    {
        get { return items.Count; }
    }

    public bool IsEmpty
    {
        get { return items.Count == 0; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Deque<int> deque = new Deque<int>();

        deque.EnqueueFront(1);
        deque.EnqueueRear(2);
        deque.EnqueueFront(3);

        Console.WriteLine("Deque contents:");
        while (!deque.IsEmpty)
        {
            Console.WriteLine(deque.DequeueFront());
        }
    }
}

