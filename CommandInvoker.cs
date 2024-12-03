public class CommandInvoker
{
    private readonly Stack<ICommand> _commandHistory = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("No commands to undo.");
        }
    }
}