namespace DesignPatterns.Factory;

public abstract class Logistics
{
    private ITransport _transport = null!;
    
    public void PlanDelivery()
    {
        Console.WriteLine("Planning delivery");
        _transport = CreateTransport();
        _transport.Deliver();
    }

    protected abstract ITransport CreateTransport();
}