namespace DesignPatterns.Behavioral.Observer;

public class Editor
{
    private EventManager manager;

    public Editor()
    {
        manager = new EventManager();
    }

    public void Subscribe(string eventName, IEventListener listener)
    {
        manager.Subscribe(listener, eventName);
    }

    public void Unsubscribe(string eventName, IEventListener listener)
    {
        manager.Unsubscribe(eventName, listener);
    }
    public void OpenFile(string fileName)
    {
        Console.WriteLine("Opening file: " + fileName);
        manager.Notify(EventManager.OPENED, fileName);
    }

    public void SaveFile(string fileName)
    {
        Console.WriteLine("Saving file: " + fileName);
        manager.Notify(EventManager.SAVED, fileName);
    }
}