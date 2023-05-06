namespace DesignPatterns.Adapter;

public interface IXmlConverter
{
    public string ConvertPersonToXml(Person person);
}