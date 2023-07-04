// See https://aka.ms/new-console-template for more information
using System;

namespace StringChallenge2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here: ");
            string input = Console.ReadLine();
            Console.Write("Enter a Character to search: ");
            char searchInput = Console.ReadLine()[0];
            int searchIndex = input.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}.", searchInput, searchIndex);

            string firstName, lastName;
            Console.Write("Enter your first name: ");
            firstName = String.Format(Console.ReadLine());
            Console.Write("Enter your last name: ");
            lastName = String.Format(Console.ReadLine());
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("My concatentation is : {0}", fullName);
            Console.ReadKey();
        }
    }
}
