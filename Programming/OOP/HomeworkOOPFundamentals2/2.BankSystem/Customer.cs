using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    abstract class Customer
    {
        //Constructor for individual
        public Customer(string firstName, string middleName, string lastName, string IDnumber)
        {
            
        }

        //Constructor for company
        public Customer(string name, string bulstat, string firstNameOfMOL, string middleNameOfMOL, string lastNameOfMOL)
        {

        }
    }
}
