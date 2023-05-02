// See https://aka.ms/new-console-template for more information

// Singleton section

using DesignPatterns.Singleton;

Settings instance1 = Settings.GetInstance();
Settings instance2 = Settings.GetInstance();

Console.WriteLine($"Response: {instance1.IsSameInstance(instance2)}");