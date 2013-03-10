using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace _2.BankSystem
{
    class Tests
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            //Try the restrictions for ID number and bulstat
            //Deposit newDeposit = new Deposit(new DateTime(2012, 05, 23), 1000m, 0.01m, new Individual("Ivan", "Peshev", "Stamatov", "0011r25144"));
            //Loan newLoan = new Loan(new DateTime(2012, 05, 23), 1000m, 0.01m, new Company("Google BG", "p44808111", "Pencho", "Kolev", "Vanchev"));

            //Create an array of accounts
            Account[] accounts = {
                                     new Deposit(new DateTime(2012,05,23), 1000m, 0.01m, new Individual("Ivan", "Peshev", "Stamatov", "0011225144")),
                                     new Deposit(new DateTime(2012,05,23), 900m, 0.01m, new Company("Google BG","144808111","Pencho","Kolev","Vanchev")),
                                     new Loan(new DateTime(2012,05,23), 1000m, 0.01m, new Individual("Pesho", "Peshev", "Rachev", "0011225144")),
                                     new Loan(new DateTime(2012,05,23), 1000m, 0.01m, new Company("Farmahim","081808192","Stamat","Kirev","Georgiev")),
                                     new Mortage(new DateTime(2012,05,23), 1000m, 0.01m, new Individual("Rosen", "Ivanov", "Krumov", "8212011414")),
                                     new Mortage(new DateTime(2012,05,23), 1000m, 0.01m, new Company("Laptop BG","343378192","Mitko","Rachkov","Popov")) 
                                 };

            
            foreach (var account in accounts)
            {
                //Print customers info (ToString method check)
                Console.WriteLine(account);
                
                //Check the CalculateInterest method - calculate the interest till the present date
                Console.WriteLine("Interest till today: {0}\n", account.CalculateInterest(DateTime.Now));
            }

            //Create new deposit
            Deposit newDeposit = new Deposit(new DateTime(2012, 05, 23), 1000m, 0.01m, new Individual("Stamo", "Stamov", "Stamatov", "0011425144"));

            //Try the Withdraw method
            newDeposit.Withdraw(500);
            Console.WriteLine("{0}\n",newDeposit);


            //Try the Deposit method
            newDeposit.Deposit(100);
            Console.WriteLine(newDeposit);
        }
    }
}
