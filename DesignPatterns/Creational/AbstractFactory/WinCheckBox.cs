namespace DesignPatterns.Creational.AbstractFactory;

public class WinCheckBox : ICheckBox
{
    public void OnClick()
    {
       Console.WriteLine("WinCheckBox clicked"); 
    }
}