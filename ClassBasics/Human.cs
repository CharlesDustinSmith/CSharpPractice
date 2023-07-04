using System;

namespace HumanClass // Note: actual namespace depends on the project name.
{
    class Human
    {
        // Member variable
        // The "?" character is used to allow a character to be nullable
        private string? _firstName;
        private string? _lastName;
        private string? _eyeColor;
        private int? _age;

        // Constructor
        // Default constructor 
        public Human()
        {
            this._firstName = "Unknown";
            this._lastName = "Unknown";
            this._eyeColor = "Unknown";
            this._age = 0;
        }

        // Parameterized constructor
        public Human(string firstname, string lastname)
        {
            this._firstName = firstname;
            this._lastName = lastname;
            this._eyeColor = "Brown";
            this._age = 27;
        }

        // Parameterized constructor
        public Human(string firstname, string lastname, string eyecolor, int age)
        {
            this._firstName = firstname;
            this._lastName  = lastname;
            this._eyeColor = eyecolor;
            this._age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            System.Console.WriteLine("Hi, I'm {0} {1}, and my eye color is {2}, and I am {3} years old.", this._firstName, this._lastName, this._eyeColor, this._age);
        }

    }
}