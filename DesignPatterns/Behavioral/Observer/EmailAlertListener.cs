namespace DesignPatterns.Behavioral.Observer;

public class EmailAlertListener : IEventListener
{
    public void Update(string fileName)
    {
       Console.WriteLine("Someone saved the file: "+ fileName); 
    }
}