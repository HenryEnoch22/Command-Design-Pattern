public class WithdrawCommand : ICommand
{
    private readonly BankAccount _account;
    private readonly decimal _amount;

    public WithdrawCommand(BankAccount account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute() => _account.Withdraw(_amount);

    public void Undo() => _account.Deposit(_amount);
}