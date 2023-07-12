// See https://aka.ms/new-console-template for more information
using System; 

namespace EnvironmentVariable
{
    internal class Program

    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
	    SetEnvironmentVariable();
        }

        static void SetEnvironmentVariable()
        {
            // Set an environment variable
            string variableName = "MY_VARIABLE";
            string variableValue = "my value";
            Environment.SetEnvironmentVariable(variableName, variableValue, EnvironmentVariableTarget.Process);

            // Read an environment variable
            string variableValue = Environment.GetEnvironmentVariable(variableName);
            if (variableValue != null)
            {
                Console.WriteLine($"The value of {variableName} is {variableValue}");
            }
            else
            {
                Console.WriteLine($"The environment variable {variableName} is not set");
            }

        }
    }
}
