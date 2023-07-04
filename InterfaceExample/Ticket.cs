using System;

namespace InterfaceExample
{
    class Ticket : IEquatable<Ticket>
    {
        // Property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }
        // Simple constructor 
        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}