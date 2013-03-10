using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    class Mortage : Account
    {
        //Constructors
        public Mortage(DateTime openingDate, decimal balance, decimal interestRate, Customer owner)
            : base(openingDate, balance, interestRate, owner)
        {
        }

        //Method to calculate the interest for the period between the opening date and the new date
        public override decimal CalculateInterest(DateTime newDate)
        {
            decimal interest = 0;

            //Get the number of the months
            int totalMonths = CalculateNumberOfPassedMonths(newDate);

            //Restriction for the Mortage accounts
            if (this.owner.GetType().Name == "Individual")
            {
                if (totalMonths <= 6)
                {
                    totalMonths = 0;
                }
                else
                {
                    totalMonths = totalMonths - 6;
                }

                //Calculate interest
                interest = totalMonths * this.interestRate;
            }

            //Restriction for the Mortage accounts
            if (this.owner.GetType().Name == "Company")
            {
                if (totalMonths <= 12)
                {
                    interest = (totalMonths * interestRate) / 2;
                }
                else
                {
                    int halfInterestPeriod = 12;
                    int fullInterestPeriod = totalMonths - halfInterestPeriod;

                    //Calculate interest
                    interest = (fullInterestPeriod * this.interestRate) + (halfInterestPeriod * this.interestRate) / 2;
                }
            }
            return interest;
        }
    }
}
