// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace ArrayListC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring an ArrayList with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // Declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(300);

            myArrayList.Add("This");
            myArrayList.Add(25);
            myArrayList.Add(3.14);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add("Catdog");
            myArrayList.Add(259);
            myArrayList.Add(35.14);
            myArrayList.Add(26);
            myArrayList.Add(128.54);
            myArrayList.Add(25.3);


            // Delete element with specific value from arraylist.
            myArrayList.Remove(25);
            // Delete element at specific position
            myArrayList.RemoveAt(3);

            System.Console.WriteLine("myArrayList elements = {0}", myArrayList.Count);

            double sum = 0;
            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if(obj is double)
                {
                    sum += (double)obj;
                }else if(obj is string)
                {
                    System.Console.WriteLine("The string object is: {0}", obj);
                }
            }
            System.Console.WriteLine("\nSum of integers inside myArrayList = {0}", sum);
        }
    }
}
