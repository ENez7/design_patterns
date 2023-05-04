namespace DesignPatterns.Builder;

public class WoodenHouse : BaseHouse
{
    public WoodenHouse() {}

    public override string ToString()
    {
        return $"Wooden house with {NumberOfWalls} walls, {NumberOfDoors} doors, {NumberOfWindows} windows, {NumberOfRoof} roof and {NumberOfRooms} rooms";
    }
}