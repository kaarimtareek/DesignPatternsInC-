namespace DesignPatterns.Creational.FactoryMethod;

public class Dialog
{
    public virtual IButton CreateButton()
    {
        return new DefaultButton();
    }

    public void SomeOperation()
    {
        var product = CreateButton();
        product.DoSomething();
    }

    public int ReturnNumber(int number)
    {
        var product = CreateButton();
        return product.ReturnNumber(number);
    }
}