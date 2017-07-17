using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Saving : Account
    {
        private double balance = 0d;
        private string accountNumber;

        //Properties for Savings Class
        public double AccountBalance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
        }

        //Constructor for Savings Class
        public Saving()
        {
            this.accountNumber = "325";
            this.balance = 400;
        }

        //Methods for Savings Class
        public void CheckBalance()
        {
            Console.WriteLine(" The Savings Account: {0}, has a balance of ${1}", accountNumber, balance);
        }

        public override double Deposit(double deposit)
        {
            return AccountBalance += deposit;
        }

        public override double Withdraw(double withdraw)
        {
            return AccountBalance -= withdraw;
        }
    }
}
