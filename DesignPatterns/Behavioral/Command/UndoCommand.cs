namespace DesignPatterns.Behavioral.Command;

public class UndoCommand : Command
{
    public UndoCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
        Undo();
        return false;
    }
    
    
}