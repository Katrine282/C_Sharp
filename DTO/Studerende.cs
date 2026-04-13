namespace DTO;

public class Studerende
{
    public int ID { get; set; }
    public string Navn { get; set; }
    public DateTime Studiestart { get; set; }
    public int Alder { get; set; }
    public Studietype Studietype { get; set; }
    public int Karakter { get; set; } = -100;
    public int? HoldId { get; set; }
    
    public Studerende()
    {
    }

    public Studerende(int id, string navn, DateTime studiestart, int alder, Studietype studietype, int karakter)
    {
        ID = id;
        Navn = navn;
        Studiestart = studiestart;
        Alder = alder;
        Studietype = studietype;
        Karakter = karakter;
    }
}