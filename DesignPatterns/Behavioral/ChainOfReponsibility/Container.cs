namespace DesignPatterns.Behavioral.ChainOfReponsibility;

public abstract class Container : Component
{
    private List<Component> _components = new List<Component>();

    public void AddChild(Component component)
    {
        _components.Add(component);
        component.ParentContainer = this;
    }

    public override void ShowHelp()
    {
        Console.WriteLine("Help container ");
    }
}