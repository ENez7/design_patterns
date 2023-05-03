namespace DesignPatterns.AbstractFactory.Chairs;

public class ContemporaryChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on contemporary chair");
    }

    public bool HasLegs()
    {
        return true;
    }

    public bool IsAdjustable()
    {
        return true;
    }

    public string GetMaterial()
    {
        return "Metal/Plastic";
    }

    public int GetPrice()
    {
        return 750;
    }
}