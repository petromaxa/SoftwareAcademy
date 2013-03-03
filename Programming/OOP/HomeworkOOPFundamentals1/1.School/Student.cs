using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Student : Person, ICommentable
    {
        //Fields
        private uint classNumber;
        private List<string> comments = new List<string>();

        //Constructor
        public Student(string name, uint age, uint classNumber) : base(name,age)
        {
            this.classNumber = classNumber;
        }

        //Properties
        public uint ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
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
    }
}
