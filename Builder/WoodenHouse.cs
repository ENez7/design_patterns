namespace DesignPatterns.Builder;

public class WoodenHouse : BaseHouse
{
    public WoodenHouse() {}

    public override string ToString()
    {
        return $"Wooden house with {NumberOfWalls} wall(s), {NumberOfDoors} door(s), " +
               $"{NumberOfWindows} window(s), {NumberOfRoof} roof(s) and {NumberOfRooms} room(s)";
    }
}