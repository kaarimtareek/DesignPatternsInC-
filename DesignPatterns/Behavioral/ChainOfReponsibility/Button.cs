namespace DesignPatterns.Behavioral.ChainOfReponsibility;

public class Button : Component
{
    private string text;

    public Button(string text)
    {
        this.text = text;
    }

    public override void ShowHelp()
    {
        Console.WriteLine("Help Button "+text);
    }
}