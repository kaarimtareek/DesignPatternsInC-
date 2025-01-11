namespace DesignPatterns.Behavioral.Command;

public class Button
{
    private Command command;
    public string Text { get; set; }

    public void SetCommand(Command command)
    {
        this.command = command;
    }

    public void Click()
    {
        command.Execute();
    }

}