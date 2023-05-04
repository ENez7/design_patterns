namespace DesignPatterns.Builder;

public interface IBuilder
{
    void Reset();
    void BuildWalls(int numberOfWalls);
    void BuildDoors(int numberOfDoors);
    void BuildWindows(int numberOfWindows);
    void BuildRoof(int numberOfRoof);
    void BuildRooms(int numberOfRooms);
    BaseHouse GetHouse();
}