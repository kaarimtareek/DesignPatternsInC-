namespace DesignPatterns.Creational.AbstractFactory;

public class MacButton : IButton
{
    public void OnClick()
    {
        Console.WriteLine("MacButton clicked"); 
    }
}