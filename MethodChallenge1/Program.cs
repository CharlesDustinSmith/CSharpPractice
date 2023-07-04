// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static string _friend1 = "Chuck", _friend2 = "Dave", _friend3 = "Jacob";
        static void Main(string[] args)
        {
            GreetFriend(_friend1);
            GreetFriend(_friend2);
            GreetFriend(_friend3);
            System.Console.ReadKey();
        }

        public static void GreetFriend(string friend)
        {
            System.Console.WriteLine("Hi {0}, my friend!", friend);
        }
    }
}