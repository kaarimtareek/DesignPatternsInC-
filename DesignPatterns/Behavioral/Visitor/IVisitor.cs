namespace DesignPatterns.Behavioral.Visitor;

public interface IVisitor
{
    
    void VisitDot(Dot dot);
    void VisitCircle(Circle circle);
    void VisitRectangle(Rectangle rectangle);
}