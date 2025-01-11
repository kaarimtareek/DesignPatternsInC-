namespace DesignPatterns.Behavioral.ChainOfReponsibility;

public class Dialog: Container
{
    private string wikiPageUrl;

    public Dialog(string wikiPageUrl)
    {
        this.wikiPageUrl = wikiPageUrl;
    }

    public override void ShowHelp()
    {
        if(this.wikiPageUrl != null)
          Console.WriteLine("Wikipedia Help:"+ this.wikiPageUrl);
        else base.ShowHelp();
    }
}