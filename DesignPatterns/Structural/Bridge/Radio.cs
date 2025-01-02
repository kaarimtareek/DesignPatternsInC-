namespace DesignPatterns.Structural.Bridge;

public class Radio : IDevice
{
    private bool _isEnabled;
    private int _channel;
    private int _volume;

    public Radio(int channel, int volume)
    {
        _channel = channel;
        _volume = volume;
        _isEnabled = false;
    }

    public Radio()
    {
        _isEnabled = false;
        _channel = 0;
        _volume = 50;
    }
    public bool IsEnabled()
    {
       return _isEnabled; 
    }

    public void Enable()
    {
        _isEnabled = true;
    }
    

    public void Disable()
    {
        _isEnabled = false;
    }

    public int GetVolume()
    {
        return _volume;
    }

    public void SetVolume(int volume)
    {
        _volume = volume;
    }

    public int GetChannel()
    {
        return _channel;
    }

    public void SetChannel(int channel)
    {
        _channel = channel;
    }
}