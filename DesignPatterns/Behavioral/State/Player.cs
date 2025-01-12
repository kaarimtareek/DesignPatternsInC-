namespace DesignPatterns.Behavioral.State;

public class Player
{
    private State _state;
    public bool IsPlaying { get; set; }
    public int Volume { get; set; }
    public string CurrentSong{get;set;}
    public List<string> Playlist { get; set; }

    public Player()
    {
        Volume = 50;
        CurrentSong = "";
        Playlist = new List<string>();
    }

    public void ChangeState(State state)
    {
        _state = state;
    }

    public void ClickLock()
    {
        _state.ClickLock();
    }

    public void ClickPlay()
    {
        _state.ClickPlay();
    }

    public void ClickNext()
    {
        _state.ClickNext();
    }

    public void ClickPrevious()
    {
        _state.ClickPrevious();
    }

    public void StartPlayback()
    {
        
    }

    public void StopPlayback()
    {
        
    }

    public void NextSong()
    {
        
    }

    public void PreviousSong()
    {
        
    }

    public void FastForward(int time)
    {
        
    }

    public void Rewind()
    {
        
    }
}