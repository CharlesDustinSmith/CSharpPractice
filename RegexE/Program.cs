﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

namespace RegexE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World.");
            // defining a regular expression with a pattern
            Regex regex = new Regex(@"\d");



            // Test string
            string text = "Hi there 123";

            // Find hits
            MatchCollection hits = regex.Matches(text);

            // Anzahl der Treffer
            Console.WriteLine("{0} hits found:\n   {1}",
                              hits.Count,
                              text);

            // amount of hits
            foreach (Match aHit in hits)
            {
                GroupCollection groups = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}",
                                  groups[0].Value,
                                  groups[0].Index
                                 );
            }
            Console.ReadLine();            
        }
    }
}
