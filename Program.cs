namespace OOP_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Creating random accounts
            BankAccount account1 = new BankAccount ("238518", "Rashed", 2808.00m);
            BankAccount account2 = new BankAccount ("823541", "Riimz", 1234.32m);


            // Add the account to the bank
            bank.AddAccount (account1);
            bank.AddAccount (account2);


            // Display all accounts
            bank.DisplayAllAccount();


            // Get a specific account
            var retrievedAccount = bank.GetAccountByNumber("123456");
            if (retrievedAccount != null)
            {
                Console.WriteLine($"Retrieved Account: {retrievedAccount}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
