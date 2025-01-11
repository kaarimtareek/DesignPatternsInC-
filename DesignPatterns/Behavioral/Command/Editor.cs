namespace DesignPatterns.Behavioral.Command;

public class Editor
{
    public string Text { get; set; }

    public string GetSelection()
    {
        return Text;
    }

    public void DeleteSelection()
    {
        Text = "";
    }

    public void ReplaceSelection(string newText)
    {
        Text = newText;
    }
}