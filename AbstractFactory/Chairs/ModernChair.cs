namespace DesignPatterns.AbstractFactory.Chairs;

public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on modern chair");
    }

    public bool HasLegs()
    {
        return false;
    }

    public bool IsAdjustable()
    {
        return false;
    }

    public string GetMaterial()
    {
        return "Metal";
    }

    public int GetPrice()
    {
        return 250;
    }
}