namespace DesignPatterns.AbstractFactory.Couches;

public interface ICouch
{
    public void SitOn();
    public int GetNumberOfSeats();
    public string GetColor();
    public int GetPrice();
}