using System;

namespace VirtualOverrideDemo
{
    class Animal
    {
        // Name properties
        public string Name { get; set; }
        // Age Properties
        public int Age { get; set; }
        // Is hungry boolean to check whether the animal is hungry
        public bool IsHungry { get; set; }

        // Simple constructor
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            // In our case all our animals are hungry by default.
            this.IsHungry = true;
        }

        // An empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {
            
        }

        // A virtual method called eat which sub classes can override
        public virtual void Eat()
        {
            // Check if animal is hungry
            if(this.IsHungry)
            {
                // If yes then print the name of the animal + "is eating"
                System.Console.WriteLine("{0} is eating", this.Name);
            }
            else 
            {
                // Otherwise print that the animal is not hungry
                System.Console.WriteLine("{0} is not hungry", this.Name);
            }
        }

        // Virtual method Play
        public virtual void Play()
        {
            System.Console.WriteLine("{0} is playing", this.Name);
        }

        
    }
}