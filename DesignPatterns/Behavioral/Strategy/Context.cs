namespace DesignPatterns.Behavioral.Strategy;

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public int Execute(int a, int b)
    {
        return _strategy.Execute(a, b);
    }
}