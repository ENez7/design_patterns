using DesignPatterns.AbstractFactory.Chairs;
using DesignPatterns.AbstractFactory.Couches;
using DesignPatterns.AbstractFactory.Tables;

namespace DesignPatterns.AbstractFactory.Factories;

public class ModernFactory : IAbstractFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ICouch CreateCouch()
    {
        return new ModernCouch();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}