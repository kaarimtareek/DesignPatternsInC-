namespace DesignPatterns.Behavioral.Visitor;

public class XmlExporterVisitor : IVisitor
{
    public void VisitDot(Dot dot)
    {
     
        Console.WriteLine($"Visiting dot with X = {dot.X}, Y = {dot.Y}");
    }

    public void VisitCircle(Circle circle)
    {
        Console.WriteLine($"Visiting circle with X = {circle.X}, Y = {circle.Y}, Radius = {circle.Radius}");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        Console.WriteLine($"Visiting rectangle with X = {rectangle.X}, Y = {rectangle.Y}, Height = {rectangle.Height}, Width = {rectangle.Width}");
    }
}