namespace DesignPatterns.Behavioral.Command;

public class CopyCommand: Command
{
    public CopyCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
       application.Clipboard = editor.GetSelection();
       return false;
    }
}