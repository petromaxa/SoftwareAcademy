using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Discipline : ICommentable
    {
        //Fields
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;
        private List<string> comments = new List<string>();

        //Constructors
        public Discipline(string name)
            : this(name, 0)
        {
        }
        public Discipline(string name, uint numberOfLectures)
            : this(name, numberOfLectures, 0)
        {
        }
        public Discipline(string name, uint numberOfLectures, uint numberOfExercises)
        {
            this.name = name;
            this.numberOfExercises = numberOfExercises;
            this.numberOfLectures = numberOfLectures;
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

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public uint NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public uint NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
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
