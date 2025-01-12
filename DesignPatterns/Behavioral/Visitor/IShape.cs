namespace DesignPatterns.Behavioral.Visitor;

public interface IShape
{
    
    void Move(int x, int y);
    void Draw();
    void Accept(IVisitor visitor);
}