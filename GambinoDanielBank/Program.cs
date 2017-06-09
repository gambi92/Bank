using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GambinoDanielBank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NormalAccount> NormalAccounts = new List<NormalAccount>();
            List<SavingsAccount> SavingsAccounts = new List<SavingsAccount>();

            NormalAccounts.Add(new NormalAccount("3425435-4543-524-525", "Mr.BigMoney"));
            NormalAccounts[0].Deposit(10);
            NormalAccounts[0].Withdraw(520);
            SavingsAccounts.Add(new SavingsAccount("6654354235-35253463-53463534", "Mss.MoneySaver", 0.01));
            SavingsAccounts[0].Withdraw(300);

            Console.WriteLine("");
            Console.WriteLine("IR: "+SavingsAccounts[0].interestRate);
            Console.ReadKey();
        }
    }
}
