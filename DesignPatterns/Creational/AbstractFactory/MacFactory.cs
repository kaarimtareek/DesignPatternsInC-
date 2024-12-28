namespace DesignPatterns.Creational.AbstractFactory;

public class MacFactory : GUIFactory
{
    public IButton CreateButton()
    {
       return new MacButton(); 
    }

    public ICheckBox CreateCheckBox()
    {
        return new MacCheckBox();
    }
}