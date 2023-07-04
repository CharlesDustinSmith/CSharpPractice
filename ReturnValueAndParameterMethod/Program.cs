// See https://aka.ms/new-console-template for more information
using System;

namespace ReturnValueAndParameterMethod // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Result from the function Add: {0}", Add(int.Parse(args[0]), int.Parse(args[1])));
            System.Console.WriteLine("Result from the function Sub: {0}", Sub(int.Parse(args[0]), int.Parse(args[1])));
            System.Console.WriteLine("Result from the function Multiply: {0}", Multiply(int.Parse(args[0]), int.Parse(args[1])));
            System.Console.WriteLine("Result from the function Divide: {0}", Divide(int.Parse(args[0]), int.Parse(args[1])));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(int num1, int num2)
        {
            return (double)num1 / (double)num2;
        }
    }
}
