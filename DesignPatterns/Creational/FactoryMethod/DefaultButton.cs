namespace DesignPatterns.Creational.FactoryMethod;

public class DefaultButton : IButton
{
    public void DoSomething()
    {
       Console.WriteLine("Default product"); 
    }

    public int ReturnNumber(int number)
    {
        return number;
    }
}