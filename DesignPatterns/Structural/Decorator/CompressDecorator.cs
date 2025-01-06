namespace DesignPatterns.Structural.Decorator;

public class CompressDecorator : DataSourceDecorator
{
    public CompressDecorator(IDataSource dataSource) : base(dataSource)
    {
        
    }

    public override void WriteData(byte[] data)
    {
        Console.WriteLine("Compression decorated");
        base.WriteData(data);
    }

    public override byte[] ReadData()
    {
        Console.WriteLine("Compression decorated");   
        var data = base.ReadData();
        return data;
    }
}