namespace DesignPatterns.Adapter;

public static class AdapterClient
{
    public static void Run()
    {
        var person = new Person("John", 30, "123 Main St", "\"Hello world!\"");
        
        var xmlConverter = new XmlConverter();
        var xml = xmlConverter.ConvertPersonToXml(person);
        
        Console.WriteLine("=== XML ===");
        Console.WriteLine(xml);
        
        var xmlToJsonConverter = new XmlToJsonConverter();
        
        Console.WriteLine("=== JSON ===");
        Console.WriteLine(xmlToJsonConverter.ToJson(xml));
        
        var csvConverter = new CsvConverter();
        var csv = csvConverter.ConvertPersonToCsv(person);
        
        Console.WriteLine("=== CSV ===");
        Console.WriteLine(csv);
        
        var csvToJsonConverter = new CsvToJsonConverter();
        
        Console.WriteLine("=== JSON ===");
        Console.WriteLine(csvToJsonConverter.ToJson(csv));
        
        var persons = new List<Person>
        {
            new("John", 30, "123 Main St", "Hello world!"),
            new("Jane", 25, "456 Main St", "Goodbye world!"),
            new("Bob", 40, "789 Main St", "Hello again world!")
        };
        
        csv = csvConverter.ConvertPersonsToCsv(persons);
        
        Console.WriteLine("=== CSV ===");
        Console.WriteLine(csv);
        
        Console.WriteLine("=== JSON ===");
        Console.WriteLine(csvToJsonConverter.ToJson(csv));
    }
}