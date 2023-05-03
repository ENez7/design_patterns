using DesignPatterns.AbstractFactory.Chairs;
using DesignPatterns.AbstractFactory.Couches;
using DesignPatterns.AbstractFactory.Tables;

namespace DesignPatterns.AbstractFactory.Factories;

public class ContemporaryFactory : IAbstractFactory
{
    public IChair CreateChair()
    {
        return new ContemporaryChair();
    }

    public ICouch CreateCouch()
    {
        return new ContemporaryCouch();
    }

    public ITable CreateTable()
    {
        return new ContemporaryTable();
    }
}