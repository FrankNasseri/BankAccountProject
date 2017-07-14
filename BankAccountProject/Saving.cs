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
            get { return this.balance; }
        }

        public override void Deposit()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
