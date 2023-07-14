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
            // Get current directory for the environment variable path
            string currentDirectory = Directory.GetCurrentDirectory();

            // Set an environment variable
            string? variableName = "MY_CSHARP_ENVIRONMENT_VARIABLE";
            string? variableValue = currentDirectory;
            Environment.SetEnvironmentVariable(variableName, variableValue, EnvironmentVariableTarget.Process);

            // Read an environment variable
            variableValue = null;
            variableValue = Environment.GetEnvironmentVariable(variableName);
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
