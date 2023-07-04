// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace IEnumerableExample2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a list of type List<int> initialized with some number
            List<int> numberList = new List<int>() {8, 6, 2};
            // an array of type int[] initialized with some numbers
            int[] numberArray = new int[] {1, 7, 1, 3};
            // new line 
            System.Console.WriteLine(" ");
            // call CollectionSum() and pass the list to it
            CollectionSum(numberList);
            // new line
            System.Console.WriteLine("\n");
            // call CollectionSum() and pass the array to it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variable to store the sum of the numbers in anyCollection
            int sum = 0;
            // for each number in the collection passed to this method
            foreach(int num in anyCollection)
            {
                sum += num;
            }
            // print the sum
            System.Console.Write("Sum is {0}", sum);
        }
    }
}
