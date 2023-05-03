namespace DesignPatterns.AbstractFactory.Tables;

public interface ITable
{
    public int GetNumberOfLegs();
    public string GetMaterial();
    public int GetLenght();
    public int GetPrice();
}