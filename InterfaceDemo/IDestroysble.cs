using System; 

namespace InterfaceDemo
{
    interface IDestroyable
    {
        // Property to store the audio file of the destruction sound
        string DestructionSound { get; set; }
        // Method to destroy an object
        void Destroy();
    }
}