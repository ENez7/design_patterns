namespace DesignPatterns.Builder;

public static class BuilderClient
{
    public static void Run()
    {
        IBuilder houseBuilder = new WoodenHouseBuilder();
        Director director = new Director(houseBuilder);
        
        director.Make();

        houseBuilder = new CobblestoneHouseBuilder();
        director.ChangeBuilder(houseBuilder);
        
        director.Make();
    }
}