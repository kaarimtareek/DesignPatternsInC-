namespace DesignPatterns.Behavioral.Iterator;

public class Facebook : ISocialNetwork
{
    public IProfileIterator CreateFriendsIterator(string profileId)
    {
       return new FacebookIterator(this, profileId, "Friends");  
    }

    public IProfileIterator CreateCoworkersIterator(string profileId)
    {
       return new FacebookIterator(this, profileId, "Coworkers");  
    }

    public List<Profile>? GetSocialGraph(string profileId, string type)
    {
        return new List<Profile>();
    }
}