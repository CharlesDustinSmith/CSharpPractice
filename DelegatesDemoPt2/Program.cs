// See https://aka.ms/new-console-template for more information
using System;

namespace DelegatesDemoPt2
{
    class Person
    {
        // name property
        public string? Name { get; set; } 
        // age property
        public int? Age { get; set; }
    }

    internal class Program
    {
        // defining a delegate type called FilterDelegate that takeks a person object and return a bool
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            
            DisplayPeople("kids", people, isMinor);
            DisplayPeople("adults", people, isAdult);
            DisplayPeople("seniors", people, isSenior);

            // Here we created a new variable called filter of type FilterDelegate.
            // then we assigned an anonymous method to it instead of an already defined method
            FilterDelegate filter = delegate(Person p)
            {
                return p.Age >= 20 && p.Age <= 30; 
            };  // Dont forget the ; at the end because we are declaring a variable
                // and assigning it's value at the same time just llike int x = 3; for example

            DisplayPeople("Between 20 and 30 :", people, filter);

            DisplayPeople("All People : ", people, delegate(Person p) { return true; });

            // Lambda functions
            string searchKeyword = "A";
            DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, (p) => {
                if(p.Name.Contains(searchKeyword) && p.Age > 20)
                    return true;
                else 
                    return false;
            } );

            DisplayPeople("Exactly 25: ", people, p => p.Age == 25);

        }

        // A method to display the list of people that passes the filter condition 
        // (returns true)
        // this method will take a title to be displayed, the list of people, 
        // and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // print the title
            System.Console.WriteLine(title);

            foreach(Person p in people)
            {
                // check if this person pass the filter
                if(filter(p))
                {
                    // print the person's name and age
                    System.Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
            System.Console.Write("\n");
        }

        // ==========FILTERS==========
        static bool isMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool isAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool isSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
