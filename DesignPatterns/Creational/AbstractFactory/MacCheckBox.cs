namespace DesignPatterns.Creational.AbstractFactory;

public class MacCheckBox : ICheckBox
{
    public void OnClick()
    {
       Console.WriteLine("MacCheckBox clicked"); 
    }
}