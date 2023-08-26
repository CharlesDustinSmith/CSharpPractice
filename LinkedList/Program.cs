// See https://aka.ms/new-console-template for more information
using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node Head;

    public LinkedList()
    {
        Head = null;
    }

    public void AddNode(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.AddNode(10);
        list.AddNode(20);
        list.AddNode(30);
        list.AddNode(40);

        Console.WriteLine("Linked list elements:");
        list.Display();
    }
}
