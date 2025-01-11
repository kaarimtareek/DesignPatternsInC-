namespace DesignPatterns.Behavioral.Memento;

public class Editor
{
    
    public string Text { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int SelectionWidth { get; set; }

    public void SetCursorPosition(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public Snapshot CreateSnapshot()
    {
       return  new Snapshot(this, this.SelectionWidth, this.X, this.Y, this.Text);
    }
}