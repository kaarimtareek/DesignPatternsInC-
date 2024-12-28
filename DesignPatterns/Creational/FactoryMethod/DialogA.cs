namespace DesignPatterns.Creational.FactoryMethod;

public class DialogA : Dialog
{
    public override IButton CreateButton()
    {
       return new ButtonA();
    }


}