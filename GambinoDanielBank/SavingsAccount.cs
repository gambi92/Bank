using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GambinoDanielBank
{
    class SavingsAccount:NormalAccount
    {
        protected double interestRate;
        //public double interestRate { get; private set; }

        public SavingsAccount(string accountNumber, string userName, double interestRate) : base(accountNumber, userName, 0, 0)
        {
            this.interestRate = interestRate;
        }

        
    }
}
