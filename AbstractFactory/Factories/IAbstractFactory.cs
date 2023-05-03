using DesignPatterns.AbstractFactory.Chairs;
using DesignPatterns.AbstractFactory.Couches;
using DesignPatterns.AbstractFactory.Tables;

namespace DesignPatterns.AbstractFactory.Factories;

public interface IAbstractFactory
{
    public IChair CreateChair();
    public ICouch CreateCouch();
    public ITable CreateTable();
}