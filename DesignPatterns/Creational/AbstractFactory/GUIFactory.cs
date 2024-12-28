namespace DesignPatterns.Creational.AbstractFactory;

public interface GUIFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckBox();
}