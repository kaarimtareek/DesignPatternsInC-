namespace DesignPatterns.Behavioral.Visitor;

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public void Draw()
    {
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }
}