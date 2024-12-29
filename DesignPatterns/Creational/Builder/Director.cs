namespace DesignPatterns.Creational.Builder;

public class Director
{

    public void BuildSportCar(ICarBuilder carBuilder)
    {
        carBuilder.Reset();
        carBuilder.SetSeats(2);
        carBuilder.SetTripComputer();
        carBuilder.SetGPS();
        carBuilder.SetEngine("SportsEngine");
        
    }

    public void BuildSuvCar(ICarBuilder carBuilder)
    {
        carBuilder.Reset();
        carBuilder.SetSeats(8);
        carBuilder.SetTripComputer();
        carBuilder.SetEngine("SuvEngine");
    }
}