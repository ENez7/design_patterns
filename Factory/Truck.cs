namespace DesignPatterns.Factory;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivery made by Truck");
    }
}