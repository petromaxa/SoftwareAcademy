using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.FindStudentsByAge
{
    class FindStudentsByAge
    {
        static void Main()
        {
            var students = new Student[]
            {
                new Student{FirstName = "Pencho", LastName ="Popov", Age = 16},
                new Student{FirstName = "Gosho", LastName ="Andonov", Age = 21},
                new Student{FirstName = "Ivan", LastName ="Stoyanov", Age = 15},
                new Student{FirstName = "Krum", LastName ="Andonov", Age = 23},
                new Student{FirstName = "Anton", LastName ="Kirov", Age = 24},
                new Student{FirstName = "Stancho", LastName ="Arsov", Age = 19}
            };

            var specialStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            int studentCounter = 1;
            foreach (var student in specialStudents)
            {
                Console.WriteLine("Student {0}:", studentCounter);
                Console.WriteLine("{0} {1} - Age:{2}\n", student.FirstName, student.LastName, student.Age);
                studentCounter++;
            }
        }
    }
}
