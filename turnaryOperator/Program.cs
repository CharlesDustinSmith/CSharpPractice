// See https://aka.ms/new-console-template for more information
using System;

namespace turnaryOperator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int temperature = -5;
            string stateOfMatter = "";

            // if(temperature < 0 )
            //     stateOfMatter = "solid";
            // else 
            //     stateOfMatter = "liquid";
            temperature += 10;

            stateOfMatter = (temperature < 0) ? "solid" : ((temperature > 100) ? "gas" : "liquid");
            System.Console.WriteLine("State of matter is {0}", stateOfMatter);
            System.Console.ReadKey();
            // in short:
            int increment = 0;
            do{
                System.Console.WriteLine("Counter value: {0}", increment);
                increment++;
            } while(increment <= 20);
        }
    }
}
