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
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Display All Accounts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an operation (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add Account
                        Console.Write("Enter Account Holder Name: ");
                        string holderName = Console.ReadLine();
                        Console.Write("Enter Account Number: ");
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter Initial Deposit Amount (0 for none): ");
                        decimal initialDeposit = decimal.Parse(Console.ReadLine());

                        BankAccount newAccount;
                        if (initialDeposit > 0)
                        {
                            newAccount = new BankAccount(holderName, accountNumber, initialDeposit);
                        }
                        else
                        {
                            newAccount = new BankAccount(holderName, accountNumber, initialDeposit);
                        }

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
