namespace DesignPatterns.AbstractFactory.Chairs;

public interface IChair
{
    public void SitOn();
    public bool HasLegs();
    public bool IsAdjustable();
    public string GetMaterial();
    public int GetPrice();
}