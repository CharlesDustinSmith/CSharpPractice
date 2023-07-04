// See https://aka.ms/new-console-template for more information
// This is the new way of doing a simple hello world.
// Console.WriteLine("Hello, World!");

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Entry Point to our program */
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Hello World! :)\n");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello Suck My Balls! :P");

            
            Console.Read();

            Console.ForegroundColor = currentColor;
        }
    }
}