namespace DesignPatterns.AbstractFactory.Couches;

public class ModernCouch : ICouch
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on modern couch");
    }

    public int GetNumberOfSeats()
    {
        return 4;
    }

    public string GetColor()
    {
        return "Brown";
    }

    public int GetPrice()
    {
        return 2500;
    }
}