namespace DesignPatterns.Adapter;

public interface ICsvConverter
{
    public string ConvertPersonToCsv(Person person);
}