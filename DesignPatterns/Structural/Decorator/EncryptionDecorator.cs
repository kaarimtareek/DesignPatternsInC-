namespace DesignPatterns.Structural.Decorator;

public class EncryptionDecorator : DataSourceDecorator
{
    
    public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
    {
    }

    public override void WriteData(byte[] data)
    {
        Console.WriteLine("Encryption decorated");
        base.WriteData(data);
    }

    public override byte[] ReadData()
    {
        var data = base.ReadData();
        Console.WriteLine("Encryption decorated");
        return data;
    }
}