// See https://aka.ms/new-console-template for more information
using System;

namespace Properties // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(0);
            box.SetHeight(11);
            box.SetWidth(12);

            System.Console.WriteLine("Get Length: {0}", box.GetLength());
            System.Console.WriteLine("Get Height: {0}", box.GetHeight());
            System.Console.WriteLine("Get Width: {0}", box.GetWidth());
            System.Console.WriteLine("Get Volume: {0}", box.GetVolume());

            box.DisplayInfo();
            System.Console.WriteLine("Hello World!");
        }
    }
}
