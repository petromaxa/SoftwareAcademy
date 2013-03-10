using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    class Deposit : Account, IWithdrawable
    {
        //Constructors
        public Deposit(DateTime openingDate, decimal balance, decimal interestRate, Customer owner)
            : base(openingDate, balance, interestRate, owner)
        {
        }

        //Methods
        public void Withdraw(decimal amount)
        {
            this.balance = this.balance - amount;
        }

        //Method to calculate the interest for the period between the opening date and the new date
        public override decimal CalculateInterest(DateTime newDate)
        {
            decimal interest = 0;

            //Get the number of the months
            int totalMonths = CalculateNumberOfPassedMonths(newDate);

            //Restriction for the Deposit accounts
            if (this.balance >= 1000)
            {
                //Calculate interest
                interest = totalMonths * this.interestRate;
            }
            return interest;
        }
    }
}
