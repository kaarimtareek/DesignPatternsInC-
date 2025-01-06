namespace DesignPatterns.Structural.Decorator;

public class DataSourceDecorator : IDataSource
{
    
    protected IDataSource _dataSource;

    public DataSourceDecorator(IDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public virtual void WriteData(byte[] data)
    {
        
        _dataSource.WriteData(data);
    }

    public virtual byte[] ReadData()
    {
        var data = _dataSource.ReadData();
        return data;
    }
}