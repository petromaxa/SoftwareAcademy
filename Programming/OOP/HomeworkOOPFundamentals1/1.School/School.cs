using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class School
    {
        //Fields
        private string name;
        private List<SchoolClass> classes= new List<SchoolClass>();

        //Constructor
        public School(string name)
        {
            this.name = name;
        }

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }
        }

        //Method that add classes
        public void AddClass(SchoolClass newClass)
        {
            this.classes.Add(newClass);
        }

        //Method that removes classes on position in the list
        public void RemoveClassAt(int index)
        {
            this.classes.RemoveAt(index);
        }
    }
}
