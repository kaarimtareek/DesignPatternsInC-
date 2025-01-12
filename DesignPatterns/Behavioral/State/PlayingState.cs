using DesignPatterns.Behavioral.Observer;

namespace DesignPatterns.Behavioral.State;

public class PlayingState : State
{
    public PlayingState(Player player) : base(player)
    {
    }

    public override void ClickLock()
    {
        
        _player.ChangeState(new LockedState(_player));
    }

    public override void ClickPlay()
    {
        _player.StopPlayback();
        _player.ChangeState(new PlayingState(_player));
    }

    public override void ClickNext()
    {
        if (
            //event.IsDoubleClick
            true)
        {
            _player.NextSong();
        }
        else
        {
            _player.FastForward(5);
        }
            
    }

    public override void ClickPrevious()
    {
        if (true
            //event.IsDoubleClick
           )
        {
            _player.PreviousSong();
        }
        else
        {
            _player.Rewind();
        }
    }
}