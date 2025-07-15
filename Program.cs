namespace OOP_Task
{
    internal class Program
    {

        static void Main(string[] args)
{
    Bank bank = new Bank();
    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("\n--- Bank Account Management System ---");
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Display All Accounts");
        Console.WriteLine("5. View Balance");
        Console.WriteLine("6. View Transaction History");
        Console.WriteLine("7. Exit");
        Console.Write("Choose an operation (1-7): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                // Create Account
                Console.Write("Enter Account Holder Name: ");
                string holderName = Console.ReadLine();
                Console.Write("Enter Account Number: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Enter Initial Deposit Amount: ");
                decimal initialDeposit = decimal.Parse(Console.ReadLine());

                BankAccount newAccount = new BankAccount(holderName, accountNumber, initialDeposit);
                bank.AddAccount(newAccount);
                Console.WriteLine("Account added successfully.");
                break;

            case "2":
                // Deposit Money
                Console.Write("Enter Account Number for Deposit: ");
                string depositAccountNumber = Console.ReadLine();
                var depositAccount = bank.GetAccountByNumber(depositAccountNumber);
                if (depositAccount != null)
                {
                    Console.Write("Enter Deposit Amount: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    depositAccount.Deposit(depositAmount);
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
                break;

            case "3":
                // Withdraw Money
                Console.Write("Enter Account Number for Withdrawal: ");
                string withdrawAccountNumber = Console.ReadLine();
                var withdrawAccount = bank.GetAccountByNumber(withdrawAccountNumber);
                if (withdrawAccount != null)
                {
                    Console.Write("Enter Withdrawal Amount: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    withdrawAccount.Withdraw(withdrawAmount);
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
                break;

            case "4":
                // Display All Accounts
                bank.DisplayAllAccount();
                break;

            case "5":
                // View Balance
                Console.Write("Enter Account Number to View Balance: ");
                string balanceAccountNumber = Console.ReadLine();
                var balanceAccount = bank.GetAccountByNumber(balanceAccountNumber);
                if (balanceAccount != null)
                {
                    Console.WriteLine($"Account Balance: {balanceAccount.Balance:C}");
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
                break;

            case "6":
                // View Transaction History
                Console.Write("Enter Account Number to View Transaction History: ");
                string historyAccountNumber = Console.ReadLine();
                var historyAccount = bank.GetAccountByNumber(historyAccountNumber);
                if (historyAccount != null)
                {
                    historyAccount.DisplayTransactionHistory();
                }
                else
                {
                    Console.WriteLine("Account not found.");
                }
                break;

            case "7":
                // Exit
                exit = true;
                Console.WriteLine("Exiting the program.");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}

    }
}
