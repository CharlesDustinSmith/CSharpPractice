// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

namespace PropertiesPt2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(9, 10, 11);
            System.Console.WriteLine("Get Length: {0}", box.Length);
            System.Console.WriteLine("Get Height: {0}", box.Height);
            System.Console.WriteLine("Get Width: {0}", box.Width);
            System.Console.WriteLine("Get Volume: {0}", box.Volume);
            box.DisplayInfo();

            box.Length = 10;
            box.Height = -11;
            box.Width = 12;
            System.Console.WriteLine("\nGet Length: {0}", box.Length);
            System.Console.WriteLine("Get Height: {0}", box.Height);
            System.Console.WriteLine("Get Width: {0}", box.Width);
            System.Console.WriteLine("Get Volume: {0}", box.Volume);
            box.DisplayInfo();
            
            System.Console.WriteLine("Hello World!");
        }
    }
}
