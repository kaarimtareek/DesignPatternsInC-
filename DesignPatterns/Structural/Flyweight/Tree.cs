namespace DesignPatterns.Structural.Flyweight;

public class Tree
{
    private int x;
    private int y;
    private TreeType treeType;
    public Tree(int y, int x, TreeType treeType)
    {
        this.y = y;
        this.x = x; 
        this.treeType = treeType;
    }

    public void Draw()
    {
        treeType.Draw(x, y);
    }
}