namespace DesignPatterns.Structural.Flyweight;

public class Forest
{
    
    private List<Tree> _trees;

    public Forest(List<Tree> trees)
    {
        _trees = trees;
    }

    public Forest()
    {
        _trees = new List<Tree>();
    }

    public void PlantTree(int x, int y, string name, string color, string texture)
    {
        var type = TreeFactory.GetTreeType(name, color, texture);
        _trees.Add(new Tree(x, y, type));
    }

    public void Draw()
    {
        foreach (var tree in _trees)
        {
            tree.Draw();
        }
    }
}