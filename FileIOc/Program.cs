// See https://aka.ms/new-console-template for more information
using System;

namespace FileIOc // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - reading text
            string currentDirectoey = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectoey, "textFile.txt");
            string text = System.IO.File.ReadAllText(filePath);

            System.Console.WriteLine("Text file contains the following text : {0}\nAt filepath : {1}", text, filePath);

            // Example 2 - reading text
            string[] lines = System.IO.File.ReadAllLines(filePath);
            System.Console.WriteLine("Read all lines method :");

            foreach(string line in lines)
            {
                System.Console.WriteLine("\t" + line);
            }
            System.Console.ReadKey();

            string[] lines = {
                "first line  12",
                "second line 123",
                "third line 23",
                "forth line third",
                "fifth line",
                "sixth line third", 
                "seventh line 23"
            };

            File.WriteAllLines(currentDirectoey + "/textfile2.txt", lines);

            using(StreamWriter file = new StreamWriter(currentDirectoey + "/myText.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(currentDirectoey + "/myText.txt", true))
            {
                file.WriteLine("Additional Line......");
            }            

        }
    }
}
