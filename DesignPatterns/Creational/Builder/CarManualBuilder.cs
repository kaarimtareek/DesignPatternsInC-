namespace DesignPatterns.Creational.Builder;

public class CarManualBuilder : ICarBuilder
{
    private Manual manual;

    public CarManualBuilder()
    {
        this.Reset();
    }
    public void Reset()
    {
       manual = new Manual(); 
    }

    public void SetSeats(int seats)
    {
        manual.Seats = seats;
    }

    public void SetEngine(String engine)
    {
       manual.Engine = engine; 
    }

    public void SetGPS()
    {
        manual.GPS = true;
    }

    public void SetTripComputer()
    {
        manual.TripComputer = true;
    }
    public Manual GetResult(){return manual;}
}
