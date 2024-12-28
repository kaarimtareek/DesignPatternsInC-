namespace DesignPatterns.Creational.FactoryMethod;

public class ButtonA : IButton
{
    public void DoSomething()
    {
        Console.WriteLine("Button A");
    }

    public int ReturnNumber(int number)
    {
        return number + 10;
    }
}