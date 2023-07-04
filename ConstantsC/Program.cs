// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantC // Note: actual namespace depends on the project name.
{
    // Constants are immutable values which are known 
    // at compile time and do not change for the life of the program.
    internal class Program
    {
        // constants as fields
        const double pi = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string birthday = "29.11.1995";
        static void Main(string[] args)
        {
            System.Console.WriteLine("My birthday is {0}", birthday);  
        }
    }
}
