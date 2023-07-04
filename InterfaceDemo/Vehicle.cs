using System;

namespace InterfaceDemo
{
    // Base class for vehicles
    class Vehicle 
    {
        // Speed of the vehicle
        public float Speed { get; set; }
        // Color of the vehicle
        public string Color { get; set; }
        // Default constructor
        public Vehicle()
        {
            this.Speed = 120f;
            this.Color = "White";
        }
        // Simple Constructor
        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}