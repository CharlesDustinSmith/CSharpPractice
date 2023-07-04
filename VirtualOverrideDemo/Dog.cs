using System;

namespace VirtualOverrideDemo
{
    class Dog : Animal
    {
        // Bool property to check if the dog is happy
        public bool IsHappy { get; set; }

        // Simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            // All Dogs are happy 
            this.IsHappy = true;
        }

        // Simple override of the virtual method Eat
        public override void Eat()
        {
            // To call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        public override void MakeSound()
        {
            // Since every animal will make a totally different sound
            // each animal will implement their own version of MakeSound
            System.Console.WriteLine("Wuff!");
        }

        public override void Play()
        {
            if(this.IsHappy)
                base.Play();
            else 
                System.Console.WriteLine("Dog is not happy");
        }
    }
}