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

        public double AccountBalance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        public Saving()
        {
            this.accountNumber = "325";
            this.balance = 100;
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
