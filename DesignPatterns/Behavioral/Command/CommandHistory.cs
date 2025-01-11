namespace DesignPatterns.Behavioral.Command;

public class CommandHistory
{
    public Stack<Command?> commands = new();

    public void Push(Command? command)
    {
        commands.Push(command);
    }

    public Command? Pop()
    {
        if (commands.Count == 0)
            return null;
        return commands.Pop();
    }
}