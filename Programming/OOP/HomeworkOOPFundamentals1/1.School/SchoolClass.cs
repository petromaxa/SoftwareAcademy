using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class SchoolClass : ICommentable
    {
        //Fields
        private List<string> comments = new List<string>();
        private string textIdentifier;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        //Constructor
        public SchoolClass(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
        }

        //Properties
        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.textIdentifier = value;
                }
                else
                {
                    throw new ArgumentException("The text identifier cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.Students;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }

        //Method that add teachers
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        //Method that removes teachers on position in the list
        public void RemoveTeacherAt(int index)
        {
            this.teachers.RemoveAt(index);
        }

        //Method that add students
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        //Method that removes students on position in the list
        public void RemoveStudentAt(int index)
        {
            this.students.RemoveAt(index);
        }

        //Method that clear all students from the list
        public void ClearStudents()
        {
            this.students.Clear();
        }

        //Method that clear all teachers from the list
        public void ClearTeachers()
        {
            this.teachers.Clear();
        }

        //Add comment method
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        //Clear all comments method
        public void ClearComments()
        {
            this.comments.Clear();
        } 

        //Override ToString method
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(textIdentifier).Append(":\n\n");
            str.Append("Teachers:\n");
            for (int i = 0; i < teachers.Count; i++)
            {
                str.Append(teachers[i].Name).Append(" ( ");
                for (int j = 0; j < teachers[i].Disciplines.Count; j++)
                {
                    if (j == 0)
                    {
                        str.Append(teachers[i].Disciplines[j].Name);
                    }
                    else
                    {
                        str.Append(", ").Append(teachers[i].Disciplines[j].Name);
                    }
                }
                str.Append(" )\n");
            }
            str.Append("\nStudents:\n");
            for (int i = 0; i < students.Count; i++)
            {
                str.Append(students[i].Name).Append("\n");
            }
 	        return Convert.ToString(str);
        }
    }
}
