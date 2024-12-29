namespace DesignPatterns.Creational.Prototype;

public class Shape : IPrototype
{
    public int X { get; set; }
    public int Y { get; set; }
    public String Color { get; set; }

    public Shape(int x, int y, string color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public Shape(Shape shape)
    {
        X = shape.X;
        Y = shape.Y;
        Color = shape.Color;
    }

    public virtual IPrototype Clone()
    {
        return new Shape(this);
    }
}