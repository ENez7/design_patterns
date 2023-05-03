// See https://aka.ms/new-console-template for more information

using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;

/*
 *
 *  Uncomment the code below to test a specific pattern
 * 
 */

/*
 *  Singleton section
 */

// var instance1 = Settings.GetInstance();
// var instance2 = Settings.GetInstance();
//
// Console.WriteLine($"Response: {instance1.IsSameInstance(instance2)}");

/*
 *  Factory section
 */
// Logistics logistics = null!;
//
// Console.WriteLine("Select logistics type:");
// Console.WriteLine("1. Road logistics");
// Console.WriteLine("2. Sea logistics");
// var option = Convert.ToInt32(Console.ReadLine());
// switch (option)
// {
//     case 1:
//         logistics = new RoadLogistics();
//         break;
//     case 2:
//         logistics = new SeaLogistics();
//         break;
//     default:
//         Console.WriteLine("No logistics found for that option");
//         break;
// }
//
// logistics.PlanDelivery();

/*
 *  Abstract Factory section
 */

Console.WriteLine("Select family of products:");
Console.WriteLine("1. Modern");
Console.WriteLine("2. Victorian");
Console.WriteLine("3. Contemporary");

var option = Convert.ToInt32(Console.ReadLine());

IAbstractFactory factory = option switch
{
    1 => new ModernFactory(),
    2 => new VictorianFactory(),
    3 => new ContemporaryFactory(),
    _ => null!
};

var chair = factory.CreateChair();
var couch = factory.CreateCouch();
var table = factory.CreateTable();

// Checking for types
Console.WriteLine($"Chair type: {chair.GetType()}");
Console.WriteLine($"Couch type: {couch.GetType()}");
Console.WriteLine($"Table type: {table.GetType()}");