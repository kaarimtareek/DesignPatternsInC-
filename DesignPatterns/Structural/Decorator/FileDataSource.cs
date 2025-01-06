namespace DesignPatterns.Structural.Decorator;

public class FileDataSource : IDataSource
{
    private string _fileName;

    public FileDataSource(string fileName)
    {
        _fileName = fileName;
    }

    public void WriteData(byte[] data)
    {
        Console.WriteLine("Writing Data to File");
    }

    public byte[] ReadData()
    {
        byte[] data = new byte[1024];
        return data;
    }
    
    
}