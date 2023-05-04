namespace DesignPatterns.Builder;

public class Director
{ // ESTO ESTA BIEN PERO SE DEBE CORREGIR POR LA CONFUSION
    public BaseHouse BuildWoodenHouse(IBuilder builder)
    {
        builder.Reset();
        builder.BuildWalls(4);
        builder.BuildDoors(1);
        builder.BuildWindows(4);
        builder.BuildRoof(1);
        builder.BuildRooms(1);

        return builder.GetHouse();
    }
    
    public BaseHouse BuildCobblestoneHouse(IBuilder builder)
    {
        builder.Reset();
        builder.BuildWalls(8);
        builder.BuildDoors(2);
        builder.BuildWindows(8);
        builder.BuildRoof(2);
        builder.BuildRooms(2);

        return builder.GetHouse();
    }
}