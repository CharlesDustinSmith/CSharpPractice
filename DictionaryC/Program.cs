// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace DictionaryC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // key - value
        // Auto - car
        static void Main(string[] args)
        {
            
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "one");
            myDictionary.Add(2, "two");
            myDictionary.Add(3, "three");
            System.Console.WriteLine(myDictionary[1]);
            Console.WriteLine("Hello World!");
        }
    }
}
