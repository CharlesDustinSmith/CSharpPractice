using System;

namespace InterfaceDemo
{
    // Subclass chair that extends Furniture
    class Chair : Furniture, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound{ get; set; }

        // Implementing the interface's method
        public void Destroy()
        {
            // When a chair gets destroyed we should play the destruction sound 
            // and spawn the destroyed chair parts
            System.Console.WriteLine("The {0} chair was destroyed", this.Color);
            System.Console.WriteLine("Playing destruction sound {0}", this.DestructionSound);
            System.Console.WriteLine("Spawning chair parts");
        }

        // Simple constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            // Initializing the interface's property with a value in the constuctor
            DestructionSound = "ChairDestructionSound.mp3";
        }
    }
}