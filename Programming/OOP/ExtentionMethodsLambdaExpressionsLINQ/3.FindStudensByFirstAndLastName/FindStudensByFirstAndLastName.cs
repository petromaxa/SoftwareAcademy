using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.FindStudensByFirstAndLastName
{
    class FindStudensByFirstAndLastName
    {
        static void Main()
        {
            var students = new Student[]
            {
                new Student{FirstName = "Pencho", LastName ="Popov"},
                new Student{FirstName = "Gosho", LastName ="Andonov"},
                new Student{FirstName = "Ivan", LastName ="Stoyanov"},
                new Student{FirstName = "Krum", LastName ="Andonov"},
                new Student{FirstName = "Anton", LastName ="Kirov"},
                new Student{FirstName = "Stancho", LastName ="Arsov"}
            };

            var specialStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            int studentCounter = 1;
            foreach (var student in specialStudents)
            {
                Console.WriteLine("Student {0}:",studentCounter);
                Console.WriteLine("{0} {1}\n",student.FirstName,student.LastName);
                studentCounter++;
            }
        }
    }
}
