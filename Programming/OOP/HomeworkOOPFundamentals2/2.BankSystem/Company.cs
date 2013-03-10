using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.BankSystem
{
    class Company : Customer
    {
        //Fields
        private string name;
        private string bulstat;
        private string firstNameOfMOL;
        private string middleNameOfMOL;
        private string lastNameOfMOL;

        //Constructor
        public Company(string name, string bulstat, string firstNameOfMOL, string middleNameOfMOL, string lastNameOfMOL) 
            : base(name,bulstat,firstNameOfMOL,middleNameOfMOL,lastNameOfMOL)
        {
            if (name != null && name.Length >= 2)
            {
                this.name = name;
            }
            else
            {
                throw new ArgumentException("The company name cannot be null and it must contain at least 2 characters!");
            }
            
            //Restriction for the bulstat to contain exactly 9 digits
            if (Regex.IsMatch(bulstat, @"^\d{9}$"))
            {
                this.bulstat = bulstat;
            }
            else
            {
                throw new ArgumentException("The bulstat number cannot be null and it must contain exactly 9 digits!");
            }

            if (firstNameOfMOL != null && firstNameOfMOL.Length >= 2)
            {
                this.firstNameOfMOL = firstNameOfMOL;
            }
            else
            {
                throw new ArgumentException("The MOL first name cannot be null and it must contain at least 2 characters!");
            }

            if (middleNameOfMOL != null && middleNameOfMOL.Length >= 2)
            {
                this.middleNameOfMOL = middleNameOfMOL;
            }
            else
            {
                throw new ArgumentException("The MOL middle name cannot be null and it must contain at least 2 characters!");
            }

            if (lastNameOfMOL != null && lastNameOfMOL.Length >= 2)
            {
                this.lastNameOfMOL = lastNameOfMOL;
            }
            else
            {
                throw new ArgumentException("The MOL last name cannot be null and it must contain at least 2 characters!");
            }
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
                    throw new ArgumentException("The company name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public string Bulstat
        {
            get
            {
                return this.bulstat;
            }
            set
            {
                //Restriction for the bulstat to contain exactly 9 digits
                if (Regex.IsMatch(value, @"^\d{9}$"))
                {
                    this.bulstat = value;
                }
                else
                {
                    throw new ArgumentException("The bulstat number cannot be null and it must contain exactly 9 digits!");
                }
            }
        }

        public string FirstNameOfMOL
        {
            get
            {
                return this.firstNameOfMOL;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.firstNameOfMOL = value;
                }
                else
                {
                    throw new ArgumentException("The MOL first name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public string MiddleNameOfMOL
        {
            get
            {
                return this.middleNameOfMOL;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.middleNameOfMOL = value;
                }
                else
                {
                    throw new ArgumentException("The MOL middle name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public string LastNameOfMOL
        {
            get
            {
                return this.lastNameOfMOL;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.lastNameOfMOL = value;
                }
                else
                {
                    throw new ArgumentException("The MOL last name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        //Method ToString
        public override string ToString()
        {
            string str = string.Format("Name: {0}\nBulstat: {1}\nMOL First Name: {2}\nMOL Middle Name: {3}\nMOL Last Name: {4}", this.name, this.bulstat, this.firstNameOfMOL, this.middleNameOfMOL, this.lastNameOfMOL);
            return str;
        }
    }
}
