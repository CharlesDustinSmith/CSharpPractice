// See https://aka.ms/new-console-template for more information
using System;

namespace InheritanceDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            Television myTV = new Television(true, "LG");
            
            // Method of child class
            myRadio.ListenRadio();
            // Method of parent class
            myRadio.SwitchOn();
            // Method of child class
            myRadio.ListenRadio();

            myTV.WatchTV();
        }
    }
}
