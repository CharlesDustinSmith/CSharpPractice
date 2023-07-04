using System;

namespace PolymorphismC
{
    class Car
    {
        // Create a base class Car with two properties HP and Color
        public int HP { get; set; }
        public string Color { get; set; }
        // has a relationship
        protected CarIdInfo carIDInfo = new CarIdInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }
        public void GetCarIdInfo()
        {
            System.Console.WriteLine("ID Number: {0}\nCar owner: {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }
        // Create a Constructor setting those two properties 
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        // Create a method called ShowDetails() which shows the HP and Color of the car on the console
        public virtual void ShowDetails()
        {
            System.Console.WriteLine("HP : {0}\nColor : {1}", this.HP, this.Color);
        }
        // Create a Repair Method which writes "Car was repaired!" onto the console
        public virtual void Repair()
        {
            System.Console.WriteLine("Car was repaired!");
        }
    }
}