namespace DesignPatterns.Builder;

public class CobblestoneHouse : BaseHouse
{
    public CobblestoneHouse() {}

    public override string ToString()
    {
        return $"Cobblestone house with {NumberOfWalls} walls, {NumberOfDoors} doors, {NumberOfWindows} windows, {NumberOfRoof} roof and {NumberOfRooms} rooms";
    }
}