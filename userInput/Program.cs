// See https://aka.ms/new-console-template for more information
using System;

namespace userInput // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string input = System.Console.Readline();
            System.Console.WriteLine(Calculate());
            System.Console.ReadKey();
        }

        public static int Calculate()
        {
            System.Console.WriteLine("Please enter the first number");
            int number1Input = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Please enter the second number");
            int number2Input = int.Parse(System.Console.ReadLine());
            
            return number1Input + number2Input;
        }
    }
}
