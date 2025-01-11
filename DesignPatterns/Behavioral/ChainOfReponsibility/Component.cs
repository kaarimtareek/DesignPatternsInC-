namespace DesignPatterns.Behavioral.ChainOfReponsibility;

public abstract class Component : IComponentWithContextualHelp
{
    public string TooltipText { get; set; }
    protected internal Container ParentContainer;
    public virtual void ShowHelp()
    {
        if (TooltipText != null)
        {
            Console.WriteLine(TooltipText);
        }
        else
        {
            ParentContainer.ShowHelp();
        }
        
    }
}