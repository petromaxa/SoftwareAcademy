using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Teacher : Person, ICommentable
    {
        //Fields
        private List<Discipline> disciplines = new List<Discipline>();
        private List<string> comments = new List<string>();

        //Constructor
        public Teacher(string name, uint age) : base(name,age)
        {
        }

        //Properties
        public List<Discipline> Disciplines
        {
            get 
            {
                return this.disciplines;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        //Method that add disciplines
        public void AddDiscipline(Discipline newDiscipline)
        {
            this.disciplines.Add(newDiscipline);
        }

        //Method that removes disciplines on position in the list
        public void RemoveDisciplineAt(int index)
        {
            this.disciplines.RemoveAt(index);
        }

        //Clear all disciplines method
        public void ClearDisciplines()
        {
            this.disciplines.Clear();
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
