namespace DesignPatterns.Adapter;

public static class AdapterClient
{
    public static void Run()
    {
        var person = new Person("John", 30, "123 Main St", "Hello world!");
        
        var xmlConverter = new XmlConverter();
        var xml = xmlConverter.ConvertPersonToXml(person);
        
        Console.WriteLine(xml);
        // Adapter
        var xmlToJsonConverter = new XmlToJsonConverter();
        Console.WriteLine(xmlToJsonConverter.ToJson(xml));
    }
}