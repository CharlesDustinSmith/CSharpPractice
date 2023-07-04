// See https://aka.ms/new-console-template for more information
using System;

namespace OperatorsC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators 
            num3 = -num1;
            System.Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            System.Console.WriteLine("Is it sunny? {0}", !isSunny);

            // Increment Operators
            int num = 0;
            num++;
            System.Console.WriteLine("num is : {0}", num);

            System.Console.ReadKey();
        }
    }
}
