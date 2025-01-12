namespace DesignPatterns.Behavioral.Strategy;

public class AddStrategy : IStrategy
{
    public int Execute(int a, int b)
    {
       return a + b; 
    }
}