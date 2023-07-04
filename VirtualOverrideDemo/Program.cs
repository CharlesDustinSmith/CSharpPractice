// See https://aka.ms/new-console-template for more information
using System;

namespace VirtualOverrideDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog newDog = new Dog("Bruno", 15);
            System.Console.WriteLine("{0} is {1} years old", newDog.Name, newDog.Age);
            newDog.Play();
            newDog.Eat();
            newDog.MakeSound();
        }
    }
}
