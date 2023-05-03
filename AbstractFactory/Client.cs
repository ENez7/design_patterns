using DesignPatterns.AbstractFactory.Chairs;
using DesignPatterns.AbstractFactory.Couches;
using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Tables;

namespace DesignPatterns.AbstractFactory;

public class Client
{
    private IChair _chair;
    private ITable _table;
    private ICouch _couch;

    public Client()
    {
        _chair = null!;
        _table = null!;
        _couch = null!;
    }
    public void AddFactory(IAbstractFactory factory)
    {
        _chair = factory.CreateChair();
        _table = factory.CreateTable();
        _couch = factory.CreateCouch();
    }

    public void ShowProducts()
    {
        Console.WriteLine($"Chair: {_chair.GetType().Name}");
        Console.WriteLine($"Table: {_table.GetType().Name}");
        Console.WriteLine($"Sofa: {_couch.GetType().Name}");
    }
}