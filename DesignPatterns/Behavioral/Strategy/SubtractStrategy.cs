namespace DesignPatterns.Behavioral.Strategy;

public class SubtractStrategy : IStrategy
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}