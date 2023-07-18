// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQToObjectAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();

        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Let's add some universities
            universities.Add(new University {Id = 1, Name = "Yale"});
            universities.Add(new University {Id = 2, Name = "Beijing Tech"});

            // Let's add some students
            students.Add(new Student {Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1});
            students.Add(new Student {Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1});
            students.Add(new Student {Id = 2, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2});
            students.Add(new Student {Id = 1, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2});
            students.Add(new Student {Id = 1, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2});
            students.Add(new Student {Id = 2, Name = "Jake", Gender = "male", Age = 31, UniversityId = 2});
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            System.Console.WriteLine("Male - Students: ");
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }
        
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            System.Console.WriteLine("Female - Students: ");
            foreach(Student student in femaleStudents)
            {
                student.Print();
            }
        }        
    }

    class University
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void Print()
        {
            System.Console.WriteLine("University {0} with id {1}", this.Name, this.Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }

        // Foreign key
        public int UniversityId { get; set; }
        public void Print()
        {
            System.Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from University with the Id {4}", this.Name, this.Id, this.Gender, this.Age, this.UniversityId);
        }
    }
}
