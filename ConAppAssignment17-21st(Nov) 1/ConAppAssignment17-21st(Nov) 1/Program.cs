using System;

class BankAccount
{
    private static int nextAccountNumber = 1;

    public int AccountNumber { get; }
    public string AccountHolderName { get; }
    private decimal Balance { get; set; }

    public BankAccount(string accountHolderName)
    {
        AccountNumber = nextAccountNumber++;
        AccountHolderName = accountHolderName;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void PrintAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount("Neha");

        myAccount.Deposit(1000);
        myAccount.Withdraw(500);

        myAccount.PrintAccountDetails();
    }
}