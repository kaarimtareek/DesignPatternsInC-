namespace DesignPatterns.Behavioral.Observer;

public class LoggingListener : IEventListener
{
    public void Update(string fileName)
    {

        if (fileName.EndsWith(".txt"))
        {
            Console.WriteLine("Logging open text file");
        }

        else if (fileName.EndsWith(".jpg"))
        {
            Console.WriteLine("Logging open image file");
        }
        else
        {
            Console.WriteLine("Someone opened the file:" + fileName);
        }
    }
}