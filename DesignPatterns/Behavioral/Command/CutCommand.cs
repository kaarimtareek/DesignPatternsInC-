namespace DesignPatterns.Behavioral.Command;

public class CutCommand: Command
{
    public CutCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
       SaveBackup();
       application.Clipboard = editor.GetSelection();
       editor.DeleteSelection();
       return true;
    }
}