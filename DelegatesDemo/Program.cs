// See https://aka.ms/new-console-template for more information
using System;

namespace DelegatesDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list of names
            List<string> names = new List<string>() {"Aiden", "Sif", "Walter", "Anatoli"};
            System.Console.WriteLine("----------before----------");
            // print the names before the remove all method
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }
            // calling removeAll and passing a method Filter we created.
            names.RemoveAll(Filter);
            System.Console.WriteLine("----------after----------");
            // print the names after the remove all method.
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }
        }

        // a methos called filter that takes a string 
        static bool Filter(string s)
        {
            // return whether the string s constains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }
    }
}