namespace DesignPatterns.Creational.FactoryMethod;

public class ButtonB : IButton
{
    public void DoSomething()
    {
       Console.WriteLine("Button B"); 
    }

    public int ReturnNumber(int number)
    {
        return number - 10;
    }
}