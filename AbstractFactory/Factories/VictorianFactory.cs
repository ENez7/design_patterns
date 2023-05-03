using DesignPatterns.AbstractFactory.Chairs;
using DesignPatterns.AbstractFactory.Couches;
using DesignPatterns.AbstractFactory.Tables;

namespace DesignPatterns.AbstractFactory.Factories;

public class VictorianFactory : IAbstractFactory
{
    public IChair CreateChair()
    {
        Console.WriteLine("Creating a new VictorianChair");
        return new VictorianChair();
    }

    public ICouch CreateCouch()
    {
        Console.WriteLine("Creating a new VictorianCouch");
        return new VictorianCouch();
    }

    public ITable CreateTable()
    {
        Console.WriteLine("Creating a new VictorianTable");
        return new VictorianTable();
    }
}