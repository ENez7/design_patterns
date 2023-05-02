namespace DesignPatterns.Singleton;

public class Settings
{
    private static Settings? _settings;

    private Settings()
    {
    }

    public static Settings GetInstance()
    {
        _settings ??= new Settings();
        return _settings;
    }

    public string IsSameInstance(Settings newSettings)
    {
        const string areSameMessage = "'Hi, we are the same'";
        const string areNotTheSameMessage = "'So sorry, we are not the same'";
        
        Console.WriteLine("If the instance is the same, you will see this:");
        Console.WriteLine(areSameMessage);
        Console.WriteLine("If not, you will see this:");
        Console.WriteLine(areNotTheSameMessage);
        Console.WriteLine("-----------------------------------------------");

        return newSettings == _settings ? areSameMessage : areNotTheSameMessage;
    }
}