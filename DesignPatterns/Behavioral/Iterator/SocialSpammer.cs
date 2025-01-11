namespace DesignPatterns.Behavioral.Iterator;

public class SocialSpammer
{

    public static void Send(IProfileIterator iterator, string message)
    {
        while (iterator.HasNext())
        {
            var profile = iterator.GetNext();
            //_notificationService.Send(profile.Email, message);
        }
        
    }
}