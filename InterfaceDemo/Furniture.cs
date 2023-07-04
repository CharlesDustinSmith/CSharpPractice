using System;

namespace InterfaceDemo
{
    class Furniture
    {
        // Color of the furniture
        public string Color { get; set; }
        // Material of the furniture
        public string Material { get; set; }
        // Default Constructor 
        public Furniture()
        {
            this.Color = "White";
            this.Material = "Wood";
        }
        // Simple Constructor
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}