using System;

namespace myProgram
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            // // Declare a variable 
            // int num1;
            // // assigning a value to a variable
            // num1 = 13;
            // // declaring and initializing a variable in one go
            // int num2 = 23;
            // int sum  = num1 + num2;
            // Console.Write("num1: " + num1 + "\n");
            // Console.Write("Sum : " + sum + "\n");
            // Console.WriteLine("num1(" + num1 + ") " + "+ num2(" + num2 + ") " + "= " + sum);

            // Console.Write("Enter your full name please : ");
            // string fullName = Console.ReadLine();
            // Console.WriteLine("Hello {0}, I hope you have a wonderful day", fullName);
            // Console.Read();
            // Console.Clear();

            // string stringForFloat = "0.85"; // datatype should be float
            // string stringForInt = "12345"; // datatype should be int
            // float num3 = float.Parse(stringForFloat);
            // int num4 = Int32.Parse(stringForInt);

            // Console.WriteLine("Answer 1 : {0}\nAnswer 2 : {1}", num3, num4);

            // define few variables
            int age = 31;
            string name = "Alfonso";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age +" years old.");

            // 2. String formatting.
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);

            // 3. String interpolation/
            // String Interpolation uses $ at the start which will allow us to write our 
            // variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, my name is {name}, I am {age} years old.", name, age);

            // 4. Verbatim strings.
            // verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
        }
    }
}
