namespace DesignPatterns.Behavioral.State;

public abstract class State
{
    protected Player _player;

    protected State(Player player)
    {
        _player = player;
    }

    public abstract void ClickLock();
    public abstract void ClickPlay();
    public abstract void ClickNext();
    public abstract void ClickPrevious();
}