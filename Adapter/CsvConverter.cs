namespace DesignPatterns.Adapter;

public class CsvConverter : ICsvConverter
{
    public string ConvertPersonToCsv(Person person)
    {
        var csv = "Name, Age, Address, Saying\n";
        csv += $"{person.Name}, {person.Age}, {person.Address}, {person.Saying}";
        return csv;
    }

    public string ConvertPersonsToCsv(List<Person> persons)
    {
        var csv = "Name, Age, Address, Saying\n";
        for (var index = 0; index < persons.Count; index++)
        {
            var person = persons[index];
            if (index == persons.Count - 1)
                csv += $"{person.Name}, {person.Age}, {person.Address}, {person.Saying}";
            else
                csv += $"{person.Name}, {person.Age}, {person.Address}, {person.Saying}\n";
        }
        return csv;
    }
}