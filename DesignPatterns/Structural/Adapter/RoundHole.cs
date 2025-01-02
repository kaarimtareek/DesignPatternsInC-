namespace DesignPatterns.Structural.Adapter;

public class RoundHole
{
    public int Radius { get; set; }

    public RoundHole(int radius)
    {
        Radius = radius;
    }

    public bool Fits(IRoundPeg roundPeg)
    {
       return Radius >= roundPeg.GetRadius(); 
    }
}