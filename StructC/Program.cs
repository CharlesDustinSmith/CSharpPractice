// See https://aka.ms/new-console-template for more information
using System;

namespace StructC // Note: actual namespace depends on the project name.
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;
        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }
        public void Display()
        {
            System.Console.WriteLine("Game's name is : {0}", this.name);
            System.Console.WriteLine("Game's was developed by : {0}", this.developer);
            System.Console.WriteLine("Game's rating is : {0}", this.rating);
            System.Console.WriteLine("Game's release date is : {0}", this.releaseDate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon GO";
            game1.developer = "Niatic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";
            game1.Display();

            Game game2 = new Game("Mario Kart", "GameFreak", 5, "01.10.2020");
            game2.Display();
        }
    }
}
