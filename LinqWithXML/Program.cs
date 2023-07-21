// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
using  System.Xml.Linq;

namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We simply apply our Student-Structure to XML.
            string studentsXML = 
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>4</Semester>                                
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>8</Semester>                                
                            </Student>
                            <Student>
                                <Name>Mike</Name>
                                <Age>21</Age>
                                <University>Florida State</University>
                                <Semester>10</Semester>                                
                            </Student>                                                       
                        </Students>";
            
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                            select new 
                            {
                                Name = student.Element("Name").Value,
                                Age = student.Element("Age").Value,
                                University = student.Element("University").Value,
                                Semester = student.Element("Semester").Value 
                            };

            foreach(var student in students)
            {
                System.Console.WriteLine("Student {0} with age {1} from University {2} and has completed {3} semesters", student.Name, student.Age, student.University, student.Semester);
            }

            var sortedStudents = from student in students
                                    orderby student.Age 
                                    select student;

            foreach(var student in sortedStudents)
            {
                System.Console.WriteLine("Student {0} with age {1} from University {2} and has completed {3} semesters", student.Name, student.Age, student.University, student.Semester);
            }
        }
    }
}
