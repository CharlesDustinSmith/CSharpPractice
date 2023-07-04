// See https://aka.ms/new-console-template for more information
using System;

namespace CodingExercise5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -10;

            while(true){
                
                // TODO
                if((i%3) == 0){
                    i++;
                    continue;
                }
                if(i == 10){
                    break;
                }
                if (i == 11)
                {
                    Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                    break;
                }
                Console.WriteLine(i++);    
            }
        }
    }
}
