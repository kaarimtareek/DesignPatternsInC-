namespace DesignPatterns.Structural.Bridge;

public class Remote
{
    protected IDevice _device;

    public Remote(IDevice device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        if (_device.IsEnabled())
            _device.Disable();
        else
            _device.Enable();
    }

    public void VolumeDown()
    {
       var volume = _device.GetVolume();
       if(volume > 0)
           _device.SetVolume(volume-1);
    }

    public void VolumeUp()
    {
        var volume = _device.GetVolume();
        if(volume <100)
            _device.SetChannel(volume+1);
        
    }

    public void ChannelUp()
    {
       var old = _device.GetChannel();
       _device.SetChannel(old-1);
    }

    public void ChannelDown()
    {
        var old = _device.GetChannel();
        _device.SetChannel(old+1);
    }
}