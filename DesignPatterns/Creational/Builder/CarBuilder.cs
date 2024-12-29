namespace DesignPatterns.Creational.Builder;

public class CarBuilder : ICarBuilder
{
    
    private Car car;

    public CarBuilder()
    {
        this.Reset();
    }
    public void Reset()
    {
       car = new Car(); 
    }

    public void SetSeats(int seats)
    {
        car.Seats = seats;
    }

    public void SetEngine(String engine)
    {
        car.Engine = engine;
    }

    public void SetGPS()
    {
        car.GPS = true;
    }

    public void SetTripComputer()
    {
        car.TripComputer = true;
    }
    public Car GetResult(){return car;}
}