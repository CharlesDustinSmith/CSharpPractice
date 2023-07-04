// See https://aka.ms/new-console-template for more information
using System;

namespace VoidMethod // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteSomething();
            WriteSomethingSpecific("Hello my friend from the other side...");
            System.Console.ReadKey(); 
        }

        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            System.Console.WriteLine("I am called from a method");       
        }

        public static void WriteSomethingSpecific(string myText)
        {
            System.Console.WriteLine(myText);
        }
    }
}
