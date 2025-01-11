namespace DesignPatterns.Behavioral.Iterator;

public interface ISocialNetwork
{

    IProfileIterator CreateFriendsIterator(string profileId);
    IProfileIterator CreateCoworkersIterator(string profileId);
}