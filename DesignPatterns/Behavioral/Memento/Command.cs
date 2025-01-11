namespace DesignPatterns.Behavioral.Memento;

public class Command
{
    
    private Snapshot _snapshot;
    private Editor _editor;

    public Command(Editor editor)
    {
        _editor = editor;
    }

    public void MakeBackup()
    {
        _snapshot = _editor.CreateSnapshot();
    }

    public void Undo()
    {
        if (_snapshot != null)
        {
            _snapshot.Restore();
        }
    }
}