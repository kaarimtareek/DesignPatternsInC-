namespace DesignPatterns.Structural.Composite;

public class Dot : IGraphic
{
    protected int X;
    protected int Y;

    public Dot(int y, int x)
    {
        Y = y;
        X = x;
    }

    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"Dot: {X}, {Y}");
    }
}