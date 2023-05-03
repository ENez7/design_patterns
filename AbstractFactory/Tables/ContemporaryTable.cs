namespace DesignPatterns.AbstractFactory.Tables;

public class ContemporaryTable : ITable
{
    public int GetNumberOfLegs()
    {
        return 4;
    }

    public string GetMaterial()
    {
        return "Oak wood";
    }

    public int GetLenght()
    {
        return 3;
    }

    public int GetPrice()
    {
        return 500;
    }
}