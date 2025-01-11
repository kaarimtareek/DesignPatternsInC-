namespace DesignPatterns.Behavioral.ChainOfReponsibility;

public class Panel : Container
{
    private string modalHelpText;

    public Panel(string modalHelpText)
    {
        this.modalHelpText = modalHelpText;
    }


    public override void ShowHelp()
    {
        if(this.modalHelpText != null)
            Console.WriteLine("Panel help:"+this.modalHelpText);
        else base.ShowHelp();
        
    }
}