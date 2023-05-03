namespace DesignPatterns.AbstractFactory.Couches;

public class VictorianCouch : ICouch
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on victorian couch");
    }

    public int GetNumberOfSeats()
    {
        return 3;
    }

    public string GetColor()
    {
        return "Golden red";
    }

    public int GetPrice()
    {
        return 5000;
    }
}