using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Tests
    {
        static void Main()
        {
            //Create a school
            School School1 = new School("SOU Ivan Vazov");

            //Create few School classes
            SchoolClass ClassA = new SchoolClass("Class A");
            SchoolClass ClassB = new SchoolClass("Class B");
            SchoolClass ClassC = new SchoolClass("Class C");
            SchoolClass ClassD = new SchoolClass("Class D");

            //Create few students
            Student student1 = new Student("Pancho Zahariev", 19, 2012219);
            Student student2 = new Student("Mario Slavov", 20, 2012219);
            Student student3 = new Student("Dimitar Penev", 21, 2012219);

            //Create few teachers
            Teacher teacher1 = new Teacher("Ivan Ivanov", 32);
            Teacher teacher2 = new Teacher("Pencho Kolev", 32);
            Teacher teacher3 = new Teacher("Svetlin Nakov", 32);

            //Create few disciplines
            Discipline discipline1 = new Discipline("Mathematics");
            Discipline discipline2 = new Discipline("Physics");
            Discipline discipline3 = new Discipline("Chemistry");
            Discipline discipline4 = new Discipline("Philosophy");
            Discipline discipline5 = new Discipline("History");
            Discipline discipline6 = new Discipline("Geography");
            Discipline discipline7 = new Discipline("Literature");
            Discipline discipline8 = new Discipline("NativeLanguage");

            //Add few disciplines to teacher1
            teacher1.AddDiscipline(discipline1);
            teacher1.AddDiscipline(discipline2);
            teacher1.AddDiscipline(discipline3);
            teacher2.AddDiscipline(discipline4);
            teacher2.AddDiscipline(discipline5);
            teacher2.AddDiscipline(discipline6);
            teacher3.AddDiscipline(discipline7);
            teacher3.AddDiscipline(discipline8);

            //Add the teachers to ClassA
            ClassA.AddTeacher(teacher1);
            ClassA.AddTeacher(teacher2);
            ClassA.AddTeacher(teacher3);

            //Add the students to ClassA
            ClassA.AddStudent(student1);
            ClassA.AddStudent(student2);
            ClassA.AddStudent(student3);

            //Try the ToString method of the SchollClass
            Console.WriteLine("ClassA first test:");
            Console.WriteLine(ClassA);

            //Try the ClearStudents and ClearTeachers methods
           // ClassA.ClearStudents();
            //ClassA.ClearTeachers();

            //Try again the ToString method of the SchollClass
            Console.WriteLine("ClassA second test(after clear students and teachers):");
            Console.WriteLine(ClassA);

            //Add some comments to student1
            student1.AddComment("Very bad behavior durring math class!");
            student1.AddComment("Very bad behavior durring geography class!");
            student1.AddComment("Very bad behavior durring literature class!");

            //Print the comments for student1
            Console.WriteLine("\nComments for student1:\n");
            for (int i = 0; i < student1.Comments.Count; i++)
            {
                Console.WriteLine(student1.Comments[i]);
            }

            //Clear the comments
            student1.ClearComments();
            Console.WriteLine("\nNew number of comments in the list of student1 after clear: {0}",student1.Comments.Count);

            //Clear the disciplines for teacher1
            teacher1.ClearDisciplines();
            Console.WriteLine("\nNew number of disciplines in the list of teacher1 after clear: {0}", teacher1.Disciplines.Count);

            discipline1.NumberOfExercises = 5;
            discipline1.NumberOfLectures = 4;

            Console.WriteLine("\nDiscipline 1 is {0}. It has {1} lectures and {2} exercises!\n",discipline1.Name,discipline1.NumberOfLectures, discipline1.NumberOfExercises);
            
            //Add classes to the school
            School1.AddClass(ClassA);
            School1.AddClass(ClassB);
            School1.AddClass(ClassC);
            School1.AddClass(ClassD);

            //Print text identifiers of the classes in shcool1
            Console.WriteLine("Print text identifiers of the classes in shcool1:");
            for (int i = 0; i < School1.Classes.Count; i++)
            {
                 Console.WriteLine(School1.Classes[i].TextIdentifier);
            }
        }
    }
}
