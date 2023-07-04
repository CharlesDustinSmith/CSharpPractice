// See https://aka.ms/new-console-template for more information
using System;

namespace ParamsExample // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            Console.WriteLine("Hello World!");
            ParamsMethod("This ", "is ", "a ", "long ", "string ", "I ", "do not ", "know ", "when ", "it ", "will ", "end ", "... ");
            ParamsMethod2(price, pi, at, book);
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {
                System.Console.Write(sentence[i] + " ");
            }
            System.Console.WriteLine("\n====================================================================");
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach(object obj in stuff)
            {
                System.Console.Write(obj + " ");
            }
            System.Console.WriteLine("\n ");
        }
    }
}
