namespace DesignPatterns.Structural.Flyweight;

public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing Tree {Name} with color {Color}, texture {Texture} in x {x}, y {y}");
    }
}