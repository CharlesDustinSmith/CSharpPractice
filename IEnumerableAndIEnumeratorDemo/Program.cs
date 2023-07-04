// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;

namespace IEnumerableAndIEnumeratorDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non generic collections


        /// <summary> IEnumerable contains a single method that you must implement when ...
        /// IEnumerator<T>, which returns an IEnumerator<T> object.
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a Current property that points at the object we are currently at in the collection. 
        /// </summary>
        /// <param name="args"></param>

        /// when it is recommended to use the IEnumerable interface: ... 

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }

    class Dog
    {
        // the name of the dog 
        public string Name { get; set; }
        // is this a naughty dog 
        public bool IsNaughtyDog { get; set; }
        // simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        // this method will print how many treats the dog recieved
        public void GiveTreat(int numberOfTreaats)
        {
            // print a message containing the number of treats and the name of the dog
            System.Console.WriteLine("Dog: {0} said wuoff {1} times!.", this.Name, numberOfTreaats);
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        // list of type List<Dog>
        public List<Dog> dogs;
        // this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            // initialize the dogs list using the collection-initializer
            this.dogs = new List<Dog>() {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", true),
                new Dog("Pixel", true)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
