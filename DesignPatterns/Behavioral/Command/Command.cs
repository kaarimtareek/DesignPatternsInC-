namespace DesignPatterns.Behavioral.Command;

public abstract class Command
{

    protected Application application;
    protected string backup;
    protected Editor editor;

    protected Command(Application application, Editor editor)
    {
        this.application = application;
        this.editor = editor;
    }

    public abstract bool Execute();

    public void SaveBackup()
    {
        backup = editor.Text;
    }

    public void Undo()
    {
        editor.Text = backup;
    }
}