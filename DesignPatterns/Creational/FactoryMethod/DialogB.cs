namespace DesignPatterns.Creational.FactoryMethod;

public class DialogB : Dialog
{
    public override IButton CreateButton()
    {
       return new ButtonB(); 
    }
}