namespace DesignPatterns.AbstractFactory.Tables;

public class ModernTable : ITable
{
    public int GetNumberOfLegs()
    {
        return 6;
    }

    public string GetMaterial()
    {
        return "Birch wood";
    }

    public int GetLenght()
    {
        return 3;
    }

    public int GetPrice()
    {
        return 300;
    }
}