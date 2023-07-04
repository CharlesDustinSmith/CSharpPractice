using System;

namespace stringFunctions // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Charles";
            string lastName = "Smith";
            string fullName = string.Concat(" ", firstName, " ",lastName);
            Console.WriteLine(firstName.Substring(2));      // Output: "arles"
            Console.WriteLine(firstName.ToLower());         // Output: "charles"
            Console.WriteLine(firstName.ToUpper());         // Output: "CHARLES"
            Console.WriteLine("Original name:{0}\nTrim name:{1}", fullName, fullName.Trim());         // Original name: " Charles Smith" Trim name: "Charles Smith"
            Console.WriteLine(firstName.IndexOf('e'));      // Output: 5
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName));        // Output: False
            Console.WriteLine("LowUpper: {0}", LowUpper(firstName));
            Count(firstName);
            Console.ReadKey();
        }
        
        public static string LowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }
        
        public static void Count(string s)
        {
            Console.WriteLine("The amount of characters is {0}", s.Length);
        }
    }
}