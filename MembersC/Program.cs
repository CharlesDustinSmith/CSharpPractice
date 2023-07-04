// See https://aka.ms/new-console-template for more information
using System;

namespace MembersC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Members member1 = new Members();
            member1.introducing(true);
            
        }
    }
}
