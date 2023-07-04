// See https://aka.ms/new-console-template for more information
using System;

namespace RandomT // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for(int i = 0; i < 100; i++)
            {
                numEyes = dice.Next(1, 7);
                System.Console.WriteLine("i:{0}\nRandom dice number between 1 and 7 is: {1}\n", i, numEyes);
            }
        }
    }
}
