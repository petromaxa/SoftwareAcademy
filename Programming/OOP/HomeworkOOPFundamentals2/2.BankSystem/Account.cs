using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    abstract class Account : IDepositable
    {
        //Fields
        protected readonly Customer owner;
        protected decimal balance;
        protected decimal interestRate;
        protected readonly DateTime openingDate;
        
        //Constructor
        public Account(DateTime openingDate, decimal balance, decimal interestRate, Customer owner)
        {
            this.openingDate = openingDate;
            this.balance = balance;
            this.interestRate = interestRate;
            this.owner = owner;
        }

        //Properties
        public Customer Owner
        {
            get
            {
                return this.owner;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public DateTime OpeningDate
        {
            get
            {
                return this.openingDate;
            }
        }

        //Method Deposit
        public void Deposit(decimal amount)
        {
            this.balance = this.balance + amount;
        }

        //Private method to calculate the number full months for the period between the opening date and the new date
        protected int CalculateNumberOfPassedMonths(DateTime newDate)
        {
            int totalMonths = 0;

            //Check if the new date is after the opening date
            if ((newDate - openingDate).TotalSeconds > 0)
            {
                //Take the number of both days in the month
                int openingDayInTheMonth = openingDate.Day;
                int newDateDayInTheMonth = newDate.Day;

                //Take the number of both months in the year
                int openingMonth = openingDate.Month;
                int newMonth = newDate.Month;

                //Take the number of the year
                int openingYear = openingDate.Year;
                int newYear = newDate.Year;

                //Calculate the number of the full months passed from the opening of the account till the new date
                if (newMonth > openingMonth)
                {
                    totalMonths = (newYear - openingYear) * 12 + (newMonth - openingMonth);
                }
                else
                {
                    totalMonths = (newYear - openingYear) * 12 - (openingMonth - newMonth);
                }

                if (newDateDayInTheMonth < openingDayInTheMonth)
                {
                    totalMonths = totalMonths - 1;
                }
            }
            else
            {
                throw new ArgumentException("Cannot calculate the interest for a time period before the opening date!");
            }

            return totalMonths;
        }


        //Method to calculate the interest for the period between the opening date and the new date
        public virtual decimal CalculateInterest(DateTime newDate)
        {
            decimal interest = 0;
            
            //Get the number of the months
            int totalMonths = CalculateNumberOfPassedMonths(newDate);

            //Calculate interest
            interest = totalMonths * this.interestRate;
            return interest;
        }

        //Override ToString
        public override string ToString()
        {
            string str = string.Format("Account type: {0}\nOwner: \n{1} \nBalance: {2}\nInterest rate: {3}\nOpening date: {4}",this.GetType().Name, this.owner, this.balance, this.interestRate, this.openingDate);
            return str;
        }
    }
}
