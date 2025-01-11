namespace DesignPatterns.Behavioral.Iterator;

public class FacebookIterator : IProfileIterator
{
    private string _profileId;
    private string _type;
    private Facebook _facebook;
    private List<Profile> _profiles;
    private int _current;
    public FacebookIterator(Facebook facebook, string profileId, string type)
    {
        _facebook = facebook;
        _type = type;
        _profileId = profileId;
        _current = 0;
    }

    public void LazyInit()
    {
        if (_profiles == null)
        {
            _profiles = _facebook.GetSocialGraph(_profileId, _type);
        }
    }
    public bool HasNext()
    {
        LazyInit();
        return _current < _profiles.Count;
    }

    public Profile GetNext()
    {
        if (HasNext())
        {
            return _profiles[_current++];
        }
        return null;
    }
}