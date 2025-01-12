namespace DesignPatterns.Behavioral.State;

public class LockedState : State
{
    public LockedState(Player player) : base(player)
    {
    }

    public override void ClickLock()
    {
        if (_player.IsPlaying)
        {
            _player.ChangeState(new PlayingState(_player) );
        }
        else
        {
            _player.ChangeState(new ReadyState(_player));
        }
    }

    public override void ClickPlay()
    {
    }

    public override void ClickNext()
    {
    }

    public override void ClickPrevious()
    {
    }
}