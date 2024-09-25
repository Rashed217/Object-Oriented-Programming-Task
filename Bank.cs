using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class Bank
    {
        private List<BankAccount> Accounts;

        public Bank()
        {
            Accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            Accounts.Add(account);
        }

        public BankAccount GetAccountByNumber(string accountNumber)
        {
            return Accounts.Find(account => account.AccountNumber == accountNumber);
        }

        public void DisplayAllAccount()
        {
            foreach (var account in Accounts)
            {
                Console.WriteLine(account);
            }
        }
    }
}
