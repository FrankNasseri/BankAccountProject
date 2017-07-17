﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account
    {
        private double balance = 0d;
        private string accountNumber;

        public double AccountBalance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Checking()
        {
            this.accountNumber = "324";
            this.balance = 400;
        }

        public void CheckBalance()
        {
            Console.WriteLine(" The checking account {0}, has a balance of {1}", accountNumber, balance);
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
