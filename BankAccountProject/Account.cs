using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class Account
    {

        public abstract double Deposit(double deposit);

        public abstract double Withdraw(double withdraw);

    }
}
