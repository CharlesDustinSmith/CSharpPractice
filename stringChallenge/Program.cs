using System;

namespace stringFunctions // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and press enter");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello my name is: {0}, \nargs[0]: {1}", name, args[0]);
            Console.WriteLine("Trim string:{0}", name.Trim());
            Console.ReadKey();
        }
    }
}
