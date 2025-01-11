namespace DesignPatterns.Behavioral.Mediator;

public interface IMediator
{
    void Notify(Component component, string eventName);
}