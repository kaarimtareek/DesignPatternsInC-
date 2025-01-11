namespace DesignPatterns.Behavioral.Observer;

public class EventManager
{
    public static readonly string SAVED = "SAVED";
    public static readonly string OPENED = "OPENED";
    private Dictionary<string, List<IEventListener>> listeners = new();

    public void Subscribe(IEventListener listener, string eventType)
    {
        if (!listeners.ContainsKey(eventType))
        {
            listeners.Add(eventType, new List<IEventListener>());
        }
        listeners[eventType].Add(listener);
    }

    public void Unsubscribe(string eventType, IEventListener listener)
    {
        listeners[eventType].Remove(listener);
    }

    public void Notify(string eventType, string filename)
    {
        foreach (var listener in listeners[eventType])
        {
            listener.Update(filename);
        }
    }
    
}