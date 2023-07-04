// See https://aka.ms/new-console-template for more information
using System;

namespace PolymorphismC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is the actual polymrophism part
            var cars = new List<Car>
            {
                new Audi(200, "white", "A4"), 
                new BMW(250, "Black", "M5"),
                new Car(110, "Blue")

            };

            foreach(var car in cars)
            {
                car.Repair();
                car.ShowDetails();
                System.Console.WriteLine("\n");
            }


            Car bmw = new BMW(200, "blue", "Z3");
            bmw.GetCarIdInfo();
            bmw.SetCarIDInfo(2345, "Mark Waller");
            bmw.GetCarIdInfo();
        }
    }
}
