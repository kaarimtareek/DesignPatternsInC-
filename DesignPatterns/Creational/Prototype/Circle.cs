namespace DesignPatterns.Creational.Prototype;

public class Circle : Shape
{
    public int Radius { get; set; }
    public Circle(int radius, int x, int y, string color) : base(x, y, color)
    {
        Radius = radius;
    }

    public Circle(Circle circle) : base(circle.X, circle.Y, circle.Color)
    {
        Radius = circle.Radius;
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }
}