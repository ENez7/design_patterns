namespace DesignPatterns.Builder;

public class Client
{
    private readonly Director _director = new();
    private IBuilder _builder;
    private BaseHouse _house = new();
    
    public void Run()
    {
        _builder = builder;
        _house = _director.BuildWoodenHouse(_builder);
        Console.WriteLine(_house.ToString());
    }
}