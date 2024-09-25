using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolderName { get; }

        private decimal Balance;

        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public decimal GetBalance()
        { 
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount:C} | New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew: {amount} | New Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds for withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }


        public string GetAccountInfo()
        {
            return $"AccountNumber: {AccountNumber}, Account Holder: {AccountHolderName}, Balance: {Balance}";
        }

    }



}
