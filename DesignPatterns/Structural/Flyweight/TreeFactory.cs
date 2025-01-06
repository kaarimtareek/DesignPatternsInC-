namespace DesignPatterns.Structural.Flyweight;

public class TreeFactory
{
    private static List<TreeType> _treeTypes = new List<TreeType>();

    private TreeFactory(List<TreeType> treeTypes)
    {
        _treeTypes = treeTypes;
    }

    public static TreeType GetTreeType(string name, string color, string texture)
    {

        var type = _treeTypes.FirstOrDefault(t => t.Name == name && t.Color == color && t.Texture == texture);
        if (type == null)
        {
            type = new TreeType(name, color, texture);
            _treeTypes.Add(type);
        }
        return type;
    }
    
}