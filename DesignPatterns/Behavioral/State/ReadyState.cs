namespace DesignPatterns.Behavioral.State;

public class ReadyState: State
{
    public ReadyState(Player player) : base(player)
    {
    }

    public override void ClickLock()
    {
        
        _player.ChangeState(new LockedState(_player));
    }

    public override void ClickPlay()
    {
        _player.StartPlayback();
        _player.ChangeState(new PlayingState(_player));
    }

    public override void ClickNext()
    {
        _player.NextSong();
    }

    public override void ClickPrevious()
    {
        _player.PreviousSong();
    }
}