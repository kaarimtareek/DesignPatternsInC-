namespace DesignPatterns.Behavioral.Command;

public class PastCommand : Command
{
    public PastCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
       SaveBackup();
       editor.ReplaceSelection(application.Clipboard);
       return true;
    }
}