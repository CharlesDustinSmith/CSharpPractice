// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring a jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] {2, 3, 5, 7, 11};
            jaggedArray[1] = new int[] {1, 2, 3};
            jaggedArray[2] = new int[] {13, 21};

            // Alternative way 
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 5, 7, 11},
                new int[] {1, 2, 3}
            };

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                System.Console.WriteLine("\nElement {0}", i);
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    System.Console.Write("{0} ", jaggedArray2[i][j]);
                }
            }
            System.Console.WriteLine("\n");

            int[][] triangle = new int[][]
            {
                new int[] {1},
                new int[] {2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9, 10},
            };

            foreach(int[] row in triangle)
            {
                foreach(int number in row)
                {
                    System.Console.WriteLine(number);
                }
            }

            System.Console.WriteLine("Value in the middle of first entry is {0}", jaggedArray2[0][2]);
        }
    }
}