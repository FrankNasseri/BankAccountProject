using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Saving : Account
    {
        private double balance = 10000d;
        public double AccountBalance
        {
            get { return balance; }
            set { this.AccountBalance = value; }
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
