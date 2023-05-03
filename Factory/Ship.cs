namespace DesignPatterns.Factory;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivery made by Ship");
    }
}