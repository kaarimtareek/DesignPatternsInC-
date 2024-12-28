namespace DesignPatterns.Creational.AbstractFactory;

public class WinButton : IButton
{
    public void OnClick()
    {
       Console.WriteLine("WinButton clicked"); 
    }
}