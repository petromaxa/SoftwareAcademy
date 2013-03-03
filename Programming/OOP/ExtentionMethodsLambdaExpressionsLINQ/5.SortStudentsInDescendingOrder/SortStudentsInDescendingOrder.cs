using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SortStudentsInDescendingOrder
{
    class SortStudentsInDescendingOrder
    {
        static void Main()
        {
            var students = new Student[]
            {
                new Student{FirstName = "Anton", LastName ="Andonov", Age = 23},
                new Student{FirstName = "Anton", LastName ="Avramov", Age = 24},
                new Student{FirstName = "Stancho", LastName ="Arsov", Age = 19},
                new Student{FirstName = "Stancho", LastName ="Borisov", Age = 19}
            };

            //Order sudents with Lambda expression
            var specialStudentsWithLambda = students.OrderByDescending(student => student.FirstName)
                  .ThenByDescending(student => student.LastName)
                  .Select(person => person);

            //Print results with Lambda expression
            Console.WriteLine("Results with Lambda expression ordering:\n");
            int studentCounter = 1;
            foreach (var student in specialStudentsWithLambda)
            {
                Console.WriteLine("Student {0}:", studentCounter);
                Console.WriteLine("{0} {1} - Age:{2}\n", student.FirstName, student.LastName, student.Age);
                studentCounter++;
            }


            //Order sudents with LINQ
            var specialStudentsWithLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            //Print results with LINQ
            Console.WriteLine("\nResults with LINQ ordering:\n");
            studentCounter = 1;
            foreach (var student in specialStudentsWithLINQ)
            {
                Console.WriteLine("Student {0}:", studentCounter);
                Console.WriteLine("{0} {1} - Age:{2}\n", student.FirstName, student.LastName, student.Age);
                studentCounter++;
            }
        }
    }
}
