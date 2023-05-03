// See https://aka.ms/new-console-template for more information

using DesignPatterns.AbstractFactory;
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

var client = new Client();

switch (option)
{
    case 1:
        client.AddFactory(new ModernFactory());
        break;
    case 2:
        client.AddFactory(new VictorianFactory());
        break;
    case 3:
        client.AddFactory(new ContemporaryFactory());
        break;
    default:
        Console.WriteLine("No family of products found for that option");
        break;
}

client.ShowProducts();
