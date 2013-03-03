using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class Person
    {
        //Fields are protected since they need to be accesible from the childs of the class Human
        protected string name;
        protected uint age;

        //Constructor
        public Person(string name, uint age)
        {
            this.name = name;
            this.age = age;
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

        public uint Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

    }
}
