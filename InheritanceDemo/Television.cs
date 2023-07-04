using System;

namespace InheritanceDemo
{
    // Child Class
    class Television : ElectricalDevice
    {
        // Simple constructor
        public Television(bool isOn, string brand) : base(isOn, brand)
        {
            System.Console.WriteLine("Television Constructor was called");
            this.isOn = isOn;
            this.Brand = brand;
        }
        
        // method to listen to the radio
        public void WatchTV()
        {
            // first check if the tv is on
            if(this.isOn)
            {
                // listen to radio
                System.Console.WriteLine("Watching the television!");
            }
            else
            {
                // print error message 
                System.Console.WriteLine("Television is switched off, switch it on first");
            }
        }        
    }
}