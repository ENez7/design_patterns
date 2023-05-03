namespace DesignPatterns.AbstractFactory.Couches;

public class ContemporaryCouch : ICouch
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on contemporary couch");
    }

    public int GetNumberOfSeats()
    {
        return 6;
    }

    public string GetColor()
    {
        return "White";
    }

    public int GetPrice()
    {
        return 3500;
    }
}