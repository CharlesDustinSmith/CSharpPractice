// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace IEnumerableExample1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(0);
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            unknownCollection = GetCollection(1);
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            unknownCollection = GetCollection(2);
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            // create a list of numbers and initialize it
            List<int> numbersList = new List<int>() {1, 2, 3, 4, 5};

            // create a queue
            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            switch(option)
            {
                case 1 : 
                {
                    System.Console.WriteLine("Option was set to {0}", option);
                    return numbersList;
                }
                case 2 : 
                {
                    System.Console.WriteLine("Option was set to {0}", option);
                    return numberQueue;
                }
                default : 
                {
                    System.Console.WriteLine("Option was neither 1 or 2");
                    return new int[] {11, 12, 13, 14, 15};
                }
            }
        }
    }
}