using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GambinoDanielBank
{
    class NormalAccount
    {
        protected string accountNumber;
        protected int amount;
        protected string userName;
        protected int limit;

        public NormalAccount(string accountNumber, string userName, int amount = 10, int limit = -500)
        {
            this.accountNumber = accountNumber;
            this.userName = userName;
            this.amount = amount;
            this.limit = limit;
            Console.WriteLine("Account created");
            Console.WriteLine("Account information: " + accountNumber + " - " + userName + " -  #  " + this.amount + "  #");
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && this.amount - amount >= limit)
            {
                this.amount -= amount;
                Console.WriteLine(amount + " withdrawed from " + accountNumber);
            } else Console.WriteLine("Withdraw denied!");
            Console.WriteLine("Account information: " + accountNumber + " - " + userName + " -  #  " + this.amount + "  #");
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.amount += amount;
                Console.WriteLine(amount + " deposited to " + accountNumber);
            } else Console.WriteLine("Deposit denied!");
            Console.WriteLine("Account information: " + accountNumber + " - " + userName + " -  #  " + this.amount + "  #");
        }

    }
}
