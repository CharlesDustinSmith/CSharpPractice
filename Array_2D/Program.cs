// See https://aka.ms/new-console-template for more information
using System;

namespace Array_2D // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 2D Array for C#
        static int[,] matrix = 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        static void Main(string[] args)
        {
            foreach(int item in matrix)
            {
                System.Console.Write(item + " ");
            }

            // This is our 2D array printed using nested for loop
            System.Console.WriteLine("\n This is our 2D array printed using nested for loop \n");
            // This will be the outer for loop (The rows)
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                // System.Console.WriteLine("Rows : {0}", i);
                // This will be the inner for loop (The columns)
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    // System.Console.WriteLine("Column : {0}", j);
                    System.Console.WriteLine("Matrix[{0},{1}]: {2}", i, j,  matrix[i,j]);
                    if((matrix[i,j] % 2) == 0)
                    {
                        System.Console.WriteLine("Even number : {0}\n", matrix[i,j]);
                    }
                }
            }
        }
    }
}
