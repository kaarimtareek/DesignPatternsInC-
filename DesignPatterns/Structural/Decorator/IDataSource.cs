namespace DesignPatterns.Structural.Decorator;

public interface IDataSource
{
    void WriteData(byte[] data);
    byte[] ReadData();
}