namespace DesignPatterns.Builder;

public class CobblestoneHouse : BaseHouse
{
    public CobblestoneHouse() {}

    public override string ToString()
    {
        return $"Cobblestone house with {NumberOfWalls} wall(s), {NumberOfDoors} door(s), " +
               $"{NumberOfWindows} window(s), {NumberOfRoof} roof(s) and {NumberOfRooms} room(s)";
    }
}