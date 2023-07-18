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
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();

            int input = Convert.ToInt32(System.Console.ReadLine());
            um.AllStudentsFromBeijingTech(input);

            int[] someInts = {30, 12, 4, 3, 12};
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reverseInts = sortedInts.Reverse();

            System.Console.WriteLine("Printing Sorted Arrays: ");
            foreach(int i in sortedInts)
            {
                System.Console.WriteLine(i);
            }
            
            System.Console.WriteLine("Printing Sorted Reverse Arrays: ");
            foreach(int i in reverseInts)
            {
                System.Console.WriteLine(i);
            }

            // or 
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            System.Console.WriteLine("Printing Sorted Reverse Arrays Pt 2: ");
            foreach(int i in reversedSortedInts)
            {
                System.Console.WriteLine(i);
            }            

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

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            
            System.Console.WriteLine("Students sorted by Age: ");
            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "Beijing Tech"
                                                select student;

            System.Console.WriteLine("Students from Beijin Tech: ");
            foreach(Student student in bjtStudents) 
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech(int id)
        {
            IEnumerable<Student> bjtStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Id == id
                                                select student;

            System.Console.WriteLine("Students from Beijin Tech:  ID: {0}", id);
            foreach(Student student in bjtStudents) 
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name};

            System.Console.WriteLine("New Collection: ");
            foreach(var col in newCollection)
            {
                System.Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
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
