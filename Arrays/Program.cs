// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[10];

            for(int i = 0; i < 10; i++) 
            {
                grades[i] = i * 10;
            }

            int counter = 0;
            foreach(int j in grades)
            {
                System.Console.WriteLine("grades[{0}] = {1}", counter, j);
                counter++;
            }

            // Another way of initializing an array 
            int[] gradesOfMathStudentsA = {20, 13, 12, 8, 8};
            // third way of initializing an array 
            int[] gradeOfMathStudentB = new int[] {15, 13, 16, 18, 12, 29};

            // Declare 2D array 
            string[,] string_matrix;

            // 3D array
            int[,,] threeD;

            // 2D array
            int[,] array2D =  new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            
        }
    }
}
