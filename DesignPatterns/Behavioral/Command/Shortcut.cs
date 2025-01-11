namespace DesignPatterns.Behavioral.Command;

public class Shortcut
{
    private string Keybind;
    private Command Command;
    public Shortcut(string keybind)
    {
        Keybind = keybind;
    }

    public void SetCommand(Command command)
    {
        Command = command;
    }

    public void OnKeyPress()
    {
        Command.Execute();
    }
}