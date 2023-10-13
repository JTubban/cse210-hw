using System.Reflection;

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

    public Person(string firstName, string lastName)
    {
        _title = firstName;
        _lastName = lastName;
    }

    public Person(string title, string firstName, string lastName)
    {
        _title = title;
        _firstName = firstName;
        _lastName = lastName;
    }
    
    public string GetInformalSigniture()
    {
        return $"Thanks, {_firstName}";
    }

    public string GetFormalSigniture()
    {
        return $"Sincirely, {GetFullName()}";
    }

    private string GetFullName()
    {
        return $"{_title} {_firstName} {_lastName}";
    }
}