using System.Collections.Specialized;
using Newtonsoft.Json;

namespace DesignPatterns.Adapter;

public class CsvToJsonConverter : IJsonConverter
{
    public string ToJson(string csv)
    {
        var lines = csv.Split("\n");
        var headers = lines[0].Split(",");
        var data = new List<Dictionary<string, string>>();
        
        for (var i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(",");
            var row = new Dictionary<string, string>();
            for (var j = 0; j < values.Length; j++)
            {
                row.Add(headers[j].Trim(), values[j].Trim());
            }
            data.Add(row);
        }

        return lines.Length == 2 
            ? JsonConvert.SerializeObject(data[0], Formatting.Indented)
            : JsonConvert.SerializeObject(data, Formatting.Indented);
    }
}