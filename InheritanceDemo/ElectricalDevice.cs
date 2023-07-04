using System;

namespace InheritanceDemo
{
    // Parent Class
    class ElectricalDevice
    {
        // Boolean to determine the state of the Electrical Device
        public bool isOn { get; set; }
        // String for the brand name of Electrical Device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            System.Console.WriteLine("Electrical Device constructor called");
            this.isOn = isOn;
            this.Brand = brand;
        }

        // Switch on the Electrical Device
        public void SwitchOn()
        {
            this.isOn = true;
        }

        // Switch off the Electrical Device
        public void SwitchOff()
        {
            this.isOn = false;
        }   
    }
}