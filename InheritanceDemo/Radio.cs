using System;

namespace InheritanceDemo
{
    // Child class
    class Radio : ElectricalDevice
    {

        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            System.Console.WriteLine("Radio constructor called");
        }

        // method to listen to the radio
        public void ListenRadio()
        {
            // first check if the radio is on
            if(this.isOn)
            {
                // listen to radio
                System.Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                // print error message 
                System.Console.WriteLine("Radio is switched off, switch it on first");
            }
        }

    }
}