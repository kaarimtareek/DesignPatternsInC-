namespace DesignPatterns.Behavioral.Command;

public class Application
{
    public List<Editor> Editors { get; set; }
    public Editor ActiveEditor { get; set; }
    public string Clipboard {get; set;}
    public CommandHistory CommandHistory { get; set; }

    public void CreateUI()
    {
        var copyCommand = new CopyCommand(this, ActiveEditor);
        var copyButton = new Button();
        copyButton.Text = "Copy";
        copyButton.SetCommand(copyCommand);
        var copyShortCut = new Shortcut("Ctrl+C");
        copyShortCut.SetCommand(copyCommand);
        
        var pastCommand = new PastCommand(this, ActiveEditor);
        var pastButton = new Button();
        pastButton.Text = "Paste";
        pastButton.SetCommand(pastCommand);
        var pastShortCut = new Shortcut("Ctrl+V");
        pastShortCut.SetCommand(pastCommand);
        
        var cutCommand = new CutCommand(this, ActiveEditor);
        var cutButton = new Button();
        cutButton.Text = "Cut";
        cutButton.SetCommand(cutCommand);
        var cutShortCut = new Shortcut("Ctrl+X");
        cutShortCut.SetCommand(cutCommand);
        
        var undoCommand = new UndoCommand(this, ActiveEditor);
        var undoButton = new Button();
        undoButton.Text = "Undo";
        undoButton.SetCommand(undoCommand);
        var undoShortCut = new Shortcut("Ctrl+Z");
        undoShortCut.SetCommand(undoCommand);
        
    }

    public void ExecuteCommand( Command command )
    {
        command.Execute();
        CommandHistory.Push(command);
        
    }

    public void Undo()
    {
        var command = CommandHistory.Pop();
        command?.Undo();
    }
}