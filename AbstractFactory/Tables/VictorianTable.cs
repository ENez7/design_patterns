namespace DesignPatterns.AbstractFactory.Tables;

public class VictorianTable : ITable
{
    public int GetNumberOfLegs()
    {
        return 4;
    }

    public string GetMaterial()
    {
        return "Dark Oak wood";
    }

    public int GetLenght()
    {
        return 2;
    }

    public int GetPrice()
    {
        return 430;
    }
}