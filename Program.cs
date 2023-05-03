// See https://aka.ms/new-console-template for more information

// Singleton section

using DesignPatterns.Factory;
using DesignPatterns.Singleton;

Settings instance1 = Settings.GetInstance();
Settings instance2 = Settings.GetInstance();

Console.WriteLine($"Response: {instance1.IsSameInstance(instance2)}");

// Factory section
Logistics logistics = null!;

Console.WriteLine("Select logistics type:");
Console.WriteLine("1. Road logistics");
Console.WriteLine("2. Sea logistics");
var option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        logistics = new RoadLogistics();
        break;
    case 2:
        logistics = new SeaLogistics();
        break;
    default:
        Console.WriteLine("No logistics found for that option");
        break;
}

logistics.PlanDelivery();