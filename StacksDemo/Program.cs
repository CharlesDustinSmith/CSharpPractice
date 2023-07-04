// See https://aka.ms/new-console-template for more information
using System;

namespace StacksDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining a new stack
            Stack<int> stack = new Stack<int>();
            // add elements to the stack using Push()
            stack.Push(1);
            stack.Push(1337);
            stack.Push(13);
            stack.Push(37);
            stack.Push(76);
            stack.Push(137);
            // Peek() will return the element at the top of the stack without removing it.
            System.Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            System.Console.WriteLine("Popped item : {0}", stack.Pop());
            System.Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
        }
    }
}
