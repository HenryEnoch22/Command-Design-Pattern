public class DepositCommand : ICommand
{
    private readonly BankAccount _account;
    private readonly decimal _amount;

    public DepositCommand(BankAccount account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute() => _account.Deposit(_amount);

    public void Undo() => _account.Withdraw(_amount);
}