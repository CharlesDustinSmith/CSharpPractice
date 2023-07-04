// See https://aka.ms/new-console-template for more information
using System;

namespace InterfaceExample // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            System.Console.WriteLine(t2.Equals(t1));
        }
    }
}
