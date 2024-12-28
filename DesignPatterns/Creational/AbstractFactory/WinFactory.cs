namespace DesignPatterns.Creational.AbstractFactory;

public class WinFactory : GUIFactory
{
    public IButton CreateButton()
    {
       return new WinButton(); 
    }

    public ICheckBox CreateCheckBox()
    {
        return new WinCheckBox();
    }
}