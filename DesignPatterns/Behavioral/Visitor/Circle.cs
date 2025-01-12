namespace DesignPatterns.Behavioral.Visitor;

public class Circle : IShape
{
    public int Radius { get; set; }
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
        visitor.VisitCircle(this);
    }
}