using System;

namespace PolymorphismC
{
    // Create two deriving classes, BMW and Audi, which have their own constructor and have an additional property 
    // called Model. Also a private member called brand. Brand should be different in each fo the two classes.
    class Audi : Car
    {
        public string Model { get; set; }
        private string Brand = "Audi";
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
        public override void ShowDetails()
        {
            System.Console.WriteLine("Brand : {0}\nHP : {1}\nColor : {2}", this.Brand, this.HP, this.Color);
        }
        public override void Repair()
        {
            System.Console.WriteLine("{0} was repaired!", this.Brand);
        }
    }
}