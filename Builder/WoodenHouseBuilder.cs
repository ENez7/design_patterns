namespace DesignPatterns.Builder;

public class WoodenHouseBuilder : IBuilder
{
    private WoodenHouse _woodenHouse = new();

    public void Reset()
    {
        _woodenHouse = new WoodenHouse();
    }

    public void BuildWalls(int numberOfWalls)
    {
        _woodenHouse.NumberOfWalls = numberOfWalls;
    }

    public void BuildDoors(int numberOfDoors)
    {
        _woodenHouse.NumberOfDoors = numberOfDoors;
    }

    public void BuildWindows(int numberOfWindows)
    {
        _woodenHouse.NumberOfWindows = numberOfWindows;
    }

    public void BuildRoof(int numberOfRoof)
    {
        _woodenHouse.NumberOfRoof = numberOfRoof;
    }

    public void BuildRooms(int numberOfRooms)
    {
        _woodenHouse.NumberOfRooms = numberOfRooms;
    }

    public BaseHouse GetHouse()
    {
        return _woodenHouse;
    }
}