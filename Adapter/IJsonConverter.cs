namespace DesignPatterns.Adapter;

public interface IJsonConverter
{
    public string ToJson(string data);
}