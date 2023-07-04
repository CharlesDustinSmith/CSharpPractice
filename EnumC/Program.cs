// See https://aka.ms/new-console-template for more information
using System;

namespace EnumC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum Day {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        enum Month {
            January = 1, 
            February,
            March,
            April,
            June,
            July = 12, 
            August, 
            September,
            October,
            November, 
            December
        };

        static void Main(string[] args)
        {
            Day holder = Day.Friday;
            Day holder2 = Day.Monday;
            Day holder3 = Day.Monday;

            System.Console.WriteLine(holder);
            System.Console.WriteLine((int)holder);
            System.Console.WriteLine(holder2 == holder3);
        }
    }
}
