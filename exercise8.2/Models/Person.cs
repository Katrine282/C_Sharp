namespace exercise8._2.Models;

public class Person
{
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }

    public Person(string fornavn, string efternavn)
    {
        Fornavn = fornavn;
        Efternavn = efternavn;
    }

    public override string ToString()
    {
        return $"{Fornavn} {Efternavn}";
    }
}