namespace DesignPatterns.Creational.Prototype;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Rectangle(int width, int height, int x, int y, string color) : base(x, y, color)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(Rectangle rectangle) : base(rectangle.X, rectangle.Y, rectangle.Color)
    {
        Width = rectangle.Width;
        Height = rectangle.Height;
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }
}