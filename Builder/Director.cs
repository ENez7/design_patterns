namespace DesignPatterns.Builder;

public class Director
{
    private IBuilder _builder;
    
    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBuilder newBuilder)
    {
        _builder = newBuilder;
    }

    public void Make()
    {
        _builder.Reset();
        Console.WriteLine("Number of doors: ");
        var input = Convert.ToInt32(Console.ReadLine());
        _builder.BuildDoors(input);
        
        Console.WriteLine("Number of roofs: ");
        input = Convert.ToInt32(Console.ReadLine());
        _builder.BuildRoof(input);
        
        Console.WriteLine("Number of windows: ");
        input = Convert.ToInt32(Console.ReadLine());
        _builder.BuildWindows(input);
        
        Console.WriteLine("Number of rooms: ");
        input = Convert.ToInt32(Console.ReadLine());
        _builder.BuildRooms(input);
        
        Console.WriteLine("Number of walls: ");
        input = Convert.ToInt32(Console.ReadLine());
        _builder.BuildWalls(input);
        
        Console.WriteLine(_builder.GetHouse());
    }
}