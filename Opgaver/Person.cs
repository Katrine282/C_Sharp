namespace Opgaver;

public class Person
{
    public string Navn { get; set; }
    private static int _id = 1;
    public int ID  { get; set; }
    public int Alder { get; set; }

    public Person(string navn, int alder)
    {
        Navn = navn;
        ID = _id++;
        Alder = alder;
    }
}