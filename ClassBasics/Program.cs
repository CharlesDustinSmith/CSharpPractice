// See https://aka.ms/new-console-template for more information
using System;
using HumanClass;

namespace ClassBasics // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class 
            // an instance of that class
            Human charles = new Human("Charles", "Smith");
            // access public variable from outside, and even change it.
            // charles.firstname = "Charles";
            // charles.lastname = "Smith";
            // // call methods of the class
            charles.IntroduceMyself();

            Human micheal = new Human();
            // micheal.firstname = "Micheal";
            // micheal.lastname = "Myer";
            micheal.IntroduceMyself();

            Human mike = new Human("Mike", "Brown", "Blue", 29);
            mike.IntroduceMyself();

            System.Console.ReadKey();
        }
    }
}
