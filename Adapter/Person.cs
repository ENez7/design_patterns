namespace DesignPatterns.Adapter;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Saying { get; set; }
    
    public Person(string name, int age, string address, string saying)
    {
        Name = name;
        Age = age;
        Address = address;
        Saying = saying;
    }
    
}