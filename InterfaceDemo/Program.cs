// See https://aka.ms/new-console-template for more information
using System;

namespace InterfaceDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects of type chair 
            Chair officeChair = new Chair("Brown", "Plastc");
            Chair gamingChair = new Chair("Red", "Wood");

            // Creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            // Add the two chairs to the IDestroyable list of the car 
            // so that when we destroy the car the destroyable objects
            // that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            // Destroy the car
            damagedCar.Destroy();
        }
    }
}
