// See https://aka.ms/new-console-template for more information
using System;

namespace DateTimeT
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995, 11, 29);
            DateTime currentTime = DateTime.Now;

            System.Console.WriteLine("Todays date is {0}", DateTime.Today);
            System.Console.WriteLine("My brithday is {0}!", dateTime);
            System.Console.WriteLine("Current Time is {0}!", currentTime);
            System.Console.WriteLine("Tomorrow is {0}!", GetTomorrow());

            TimeSpan daysPassed = currentTime.Subtract(dateTime);
            System.Console.WriteLine("Time passed from birthday to now : {0}", daysPassed.Days);

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
