// See https://aka.ms/new-console-template for more information
using System;

namespace switchStatement // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 5;

            switch(age)
            {
                case 15: 
                    System.Console.WriteLine("Too young to party in the club!");
                    break;
                case 25: 
                    System.Console.WriteLine("Good to go!");
                    break;
                default:
                    System.Console.WriteLine("Neither 15 or 15, how old are you?");
                    break;        
            }

            string username = "Charles";

            switch(username)
            {
                case "Charles":
                    System.Console.WriteLine("Username is Charles");
                    break;
                case "Root":
                    System.Console.WriteLine("Username is Root");
                    break;
                default:
                    System.Console.WriteLine("Unknown username");
                    break;
            }

            System.Console.ReadKey();      
        }
    }
}
