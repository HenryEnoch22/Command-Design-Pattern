public class BankAccount
{
    public string AccountHolder { get; }
    private decimal Balance { get; set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount:C} deposited. Current balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn. Current balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine($"Insufficient funds. Withdrawal of {amount:C} failed.");
        }
    }

    public void ShowBalance() => Console.WriteLine($"Current balance: {Balance:C}");
}

