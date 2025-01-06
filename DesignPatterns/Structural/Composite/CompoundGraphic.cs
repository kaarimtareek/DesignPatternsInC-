namespace DesignPatterns.Structural.Composite;

public class CompoundGraphic : IGraphic
{
    
    private List<IGraphic> _graphics;

    public CompoundGraphic()
    {
        _graphics = new List<IGraphic>();
    }

    public void AddGraphic(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void AddGraphics(IEnumerable<IGraphic> graphics)
    {
        _graphics.AddRange(graphics);
    }

    public void RemoveGraphic(IGraphic graphic)
    {
        _graphics.Remove(graphic);
    }

    public void Move(int x, int y)
    {
        foreach (var graphic in _graphics)
        {
            graphic.Move(x, y);
        }
    }

    public void Draw()
    {
        foreach (var graphic in _graphics)
        {
            graphic.Draw();
        }
    }
}