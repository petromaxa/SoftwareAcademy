using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.BankSystem
{
    class Individual : Customer
    {
        //Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ID_number;

        //Constructor
        public Individual(string firstName, string middleName, string lastName, string ID_number)
            : base(firstName, middleName, lastName, ID_number)
        {
            if (firstName != null && firstName.Length >= 2)
            {
                this.firstName = firstName;
            }
            else
            {
                throw new ArgumentException("The person's first name cannot be null and it must contain at least 2 characters!");
            }

            if (middleName != null && middleName.Length >= 2)
            {
                this.middleName = middleName;
            }
            else
            {
                throw new ArgumentException("The person's middle name cannot be null and it must contain at least 2 characters!");
            }

            if (lastName != null && lastName.Length >= 2)
            {
                this.lastName = lastName;
            }
            else
            {
                throw new ArgumentException("The person's last name cannot be null and it must contain at least 2 characters!");
            }

            //Restriction for the ID number to contain exactly 10 digits
            if (Regex.IsMatch(ID_number, @"^\d{10}$"))
            {
                this.ID_number = ID_number;
            }
            else
            {
                throw new ArgumentException("The person's ID number cannot be null and it must contain exactly 10 digits!");
            }
        }


        //Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("The person's first name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.middleName = value;
                }
                else
                {
                    throw new ArgumentException("The person's middle name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("The person's last name cannot be null and it must contain at least 2 characters!");
                }
            }
        }

        public string IDnumber
        {
            get
            {
                return this.ID_number;
            }
            set
            {
                //Restriction for the ID number to contain exactly 10 digits
                if (Regex.IsMatch(value, @"^\d{10}$"))
                {
                    this.ID_number = value;
                }
                else
                {
                    throw new ArgumentException("The person's ID number cannot be null and it must contain exactly 10 digits!");
                }
            }
        }

        //Override ToString
        public override string ToString()
        {
            string str = string.Format("First name: {0}\nMiddle name: {1}\nLast Name: {2}\nID number: {3}",this.firstName,this.middleName,this.lastName,this.ID_number);
            return str;
        }
    }
}
