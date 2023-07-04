// See https://aka.ms/new-console-template for more information
using System;

namespace TryAndCatchC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");

            int num1 =5, num2 = 0, result;

            try 
            {
                result = num1 / num2;
            }
            catch(Exception)
            {
                System.Console.WriteLine("Can not divide a number by zero");
            }
            finally 
            {
                System.Console.WriteLine("This happens anyways");
            }

            try
            {
                int userInput = int.Parse(System.Console.ReadLine());
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Please use numbers only instead of letters or symbols.");
            }
            catch(OverflowException)
            {
                System.Console.WriteLine("Overflow Exception, number to long or two short for Int32");
                throw;
            }
            finally
            {
                System.Console.WriteLine("This is called anyways!");
            }
            System.Console.ReadKey();

        }
    }
}
