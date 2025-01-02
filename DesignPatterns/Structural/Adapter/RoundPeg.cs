namespace DesignPatterns.Structural.Adapter;

public class RoundPeg : IRoundPeg
{
    private int _radius; 

    public RoundPeg(int radius)
    {
        _radius = radius;
    }
   public int GetRadius() => _radius; 
}