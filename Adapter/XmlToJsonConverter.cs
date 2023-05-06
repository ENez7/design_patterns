using System.Xml.Linq;
using Newtonsoft.Json;

namespace DesignPatterns.Adapter;

public class XmlToJsonConverter : IJsonConverter
{
    public string ToJson(string xmlString)
    {
        return JsonConvert.SerializeXNode(XDocument.Parse(xmlString), Formatting.Indented);
    }
}