namespace DesignPatterns.Builder;

public class CobblestoneHouseBuilder : IBuilder
{
    private CobblestoneHouse _cobblestoneHouse = new();

    public void Reset()
    {
        _cobblestoneHouse = new CobblestoneHouse();
    }

    public void BuildWalls(int numberOfWalls)
    {
        _cobblestoneHouse.NumberOfWalls = numberOfWalls;
    }

    public void BuildDoors(int numberOfDoors)
    {
        _cobblestoneHouse.NumberOfDoors = numberOfDoors;
    }

    public void BuildWindows(int numberOfWindows)
    {
        _cobblestoneHouse.NumberOfWindows = numberOfWindows;
    }

    public void BuildRoof(int numberOfRoof)
    {
        _cobblestoneHouse.NumberOfRoof = numberOfRoof;
    }

    public void BuildRooms(int numberOfRooms)
    {
        _cobblestoneHouse.NumberOfRooms = numberOfRooms;
    }

    public BaseHouse GetHouse()
    {
        return _cobblestoneHouse;
    }
}