// See https://aka.ms/new-console-template for more information
using System;

namespace MathC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            double num = 5.2231;
            System.Console.WriteLine("Ceiling : {0}", Math.Ceiling(num));
            System.Console.WriteLine("Floor : {0}", Math.Floor(num));

            int num1 = 13;
            int num2 = 9;
            System.Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
            System.Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            System.Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3, 5));
            System.Console.WriteLine("PI is {0}", Math.PI);

            System.Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));
            System.Console.WriteLine("The Always positive {0}", Math.Abs(-15));
            System.Console.WriteLine("cos(1) is : {0}", Math.Cos(1));
            System.Console.WriteLine("sin(1) is : {0}", Math.Sin(1));
            

            System.Console.ReadLine();
        }
    }
}
