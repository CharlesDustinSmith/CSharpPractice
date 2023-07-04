// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace HashtablesC // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        // Key - Value
        // Auto - Car 
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);
            
            table.Add(stud1.Id, stud1);
            table.Add(stud2.Id, stud2);
            table.Add(stud3.Id, stud3);
            table.Add(stud4.Id, stud4);

            // Retrieve individual item with known ID
            Student storedStudent1 = (Student)table[1];

            System.Console.WriteLine("Student 1 \nId: {0}\nName: {1}\nGPA: {2}\n", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            // Retrieve all values from a Hashtable
            foreach(DictionaryEntry entry in table)
            {
                Student temp = (Student)entry.Value;
                System.Console.WriteLine("Temp Student \nId: {0}\nName: {1}\nGPA: {2}\n", temp.Id, temp.Name, temp.GPA);
            }
            // Or
            foreach(Student value in table.Values)
            {
                System.Console.WriteLine("Value Student \nId: {0}\nName: {1}\nGPA: {2}\n", value.Id, value.Name, value.GPA);
            }

            Console.WriteLine("Hello World!");
            
        }

        class Student
        {
            // property called Id
            public int Id{ get; set; }
            // property called Name
            public string Name{ get; set; }
            // property called GPA
            public float GPA{ get; set; }
            // simple constructor
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }
    }
}
