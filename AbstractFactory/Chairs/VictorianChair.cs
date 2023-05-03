namespace DesignPatterns.AbstractFactory.Chairs;

public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on victorian chair");
    }

    public bool HasLegs()
    {
        return true;
    }

    public bool IsAdjustable()
    {
        return false;
    }

    public string GetMaterial()
    {
        return "Birch wood";
    }

    public int GetPrice()
    {
        return 1500;
    }
}