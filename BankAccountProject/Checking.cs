using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account
    {
        private double balance = 40000d;
        private string accountNumber;

        public double AccountBalance
        {
            get { return this.balance; }
            set { this.AccountBalance = value; }
        }

        public Checking()
        {
            this.accountNumber = "324";
            this.balance = 40000;
        }

        public void CheckBalance()
        {
            Console.WriteLine(" The checking account {0}, has a balance of {1}", accountNumber, balance);
        }

        public override double Deposit(double deposit)
        {
            AccountBalance += deposit;
        }

        public override double Withdraw(double withdraw)
        {
            AccountBalance -= withdraw; 
        }

    }
}
