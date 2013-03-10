using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    class Loan : Account
    {
        //Constructors
        public Loan(DateTime openingDate, decimal balance, decimal interestRate, Customer owner)
            : base(openingDate, balance, interestRate, owner)
        {
        }


        //Method to calculate the interest for the period between the opening date and the new date
        public override decimal CalculateInterest(DateTime newDate)
        {
            decimal interest = 0;

            //Get the number of the months
            int totalMonths = CalculateNumberOfPassedMonths(newDate);

            //Restriction for the Loan accounts
            if (this.owner.GetType().Name == "Individual")
            {
                if (totalMonths <= 3)
                {
                    totalMonths = 0;
                }
                else
                {
                    totalMonths = totalMonths - 3;
                }
            }

            //Restriction for the Loan accounts
            if (this.owner.GetType().Name == "Company")
            {
                if (totalMonths <= 2)
                {
                    totalMonths = 0;
                }
                else
                {
                    totalMonths = totalMonths - 2;
                }
            }

            //Calculate interest
            interest = totalMonths * interestRate;
            return interest;
        }
    }
}
