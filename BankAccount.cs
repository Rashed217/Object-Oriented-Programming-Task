using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class BankAccount
{
    public string HolderName { get; private set; }
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }
    private List<string> transactionHistory;

    public BankAccount(string holderName, string accountNumber, decimal initialDeposit)
    {
        HolderName = holderName;
        AccountNumber = accountNumber;
        Balance = initialDeposit;
        transactionHistory = new List<string>();

        if (initialDeposit > 0)
        {
            transactionHistory.Add($"Initial deposit: {initialDeposit:C}");
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            transactionHistory.Add($"Deposited: {amount:C}");
            Console.WriteLine("Deposit successful.");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            transactionHistory.Add($"Withdrew: {amount:C}");
            Console.WriteLine("Withdrawal successful.");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public void DisplayTransactionHistory()
    {
        Console.WriteLine($"\nTransaction History for {HolderName} (Account: {AccountNumber}):");
        if (transactionHistory.Count == 0)
        {
            Console.WriteLine("No transactions yet.");
        }
        else
        {
            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
    
}
