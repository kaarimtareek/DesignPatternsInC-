namespace DesignPatterns.Behavioral.Iterator;

public interface IProfileIterator
{
    bool HasNext();
    Profile GetNext();
}