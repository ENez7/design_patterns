namespace DesignPatterns.Adapter;

public class XmlConverter : IXmlConverter
{
    public string ConvertPersonToXml(Person person)
    {
        return $"<person><name>{person.Name}</name><age>{person.Age}</age><address>{person.Address}</address><saying>{person.Saying}</saying></person>";
    }
}