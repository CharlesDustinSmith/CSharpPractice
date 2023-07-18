// See https://aka.ms/new-console-template for more information
using System; 
using System.Linq;
using System.Collections.Generic;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            OddNumbers(numbers);
        }

        static void OddNumbers(int[] numbers)
        {
            System.Console.WriteLine("Odd Numbers: ");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            System.Console.WriteLine(oddNumbers);

            foreach(int i in oddNumbers)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
