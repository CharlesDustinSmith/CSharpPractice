// See https://aka.ms/new-console-template for more information
using System;

namespace BreakContinue // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            for(int counter = 0; counter < 10; counter++)
            {
                // System.Console.WriteLine(counter);
                // if(counter == 3)
                // {
                //     System.Console.WriteLine("At 3 we stop");
                //     break;
                // }
                if(counter == 3)
                {
                    System.Console.WriteLine("We skip number 3");
                    break;
                }
                System.Console.WriteLine(counter);
            }

            System.Console.ReadKey();
        }
    }
}
