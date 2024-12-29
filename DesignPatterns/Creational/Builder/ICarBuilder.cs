namespace DesignPatterns.Creational.Builder;

public interface ICarBuilder
{
    public void Reset();
    void SetSeats(int seats);
    void SetEngine(String engine);
    void SetGPS();
    void SetTripComputer();
}