using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {
        BankAccount account = new("Alexis Lava Ollas", 1000m);

        ICommand deposito100 = new DepositCommand(account, 100m);
        ICommand withdraw50 = new WithdrawCommand(account, 50m);

        CommandInvoker invoker = new();

        System.Console.WriteLine($"Hi, {account.AccountHolder}.");
        account.ShowBalance();

        Console.WriteLine("Executing commands...");
        invoker.ExecuteCommand(deposito100);
        invoker.ExecuteCommand(withdraw50);
        account.ShowBalance();

        Console.WriteLine("\nUndoing last command...");
        invoker.UndoLastCommand();
        account.ShowBalance();

        Console.WriteLine("\nUndoing last command...");
        invoker.UndoLastCommand();
        account.ShowBalance();

        Console.WriteLine("\nTrying to undo with no commands left...");
        invoker.UndoLastCommand();
    }
}