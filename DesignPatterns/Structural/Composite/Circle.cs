namespace DesignPatterns.Structural.Composite;

public class Circle : Dot
{
    private int _radius;
    public Circle(int y, int x, int radius) : base(y, x)
    {
        _radius = radius;
        
    }

    public override void Draw()
    {
        Console.WriteLine($"Circle X:{X}, Y:{Y} Radius:{_radius}");
    }
    
}