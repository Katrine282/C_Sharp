namespace DTO;

public class Studerende
{
    public int ID { get; set; }
    public string Navn { get; set; }
    public DateTime Studiestart { get; set; }
    public int Alder { get; set; }
    public Studietype Studietype { get; set; }
    public int? HoldId { get; set; }
    
    public Studerende()
    {
    }

    public Studerende(int id, string navn, DateTime studiestart, int alder, Studietype studietype)
    {
        ID = id;
        Navn = navn;
        Studiestart = studiestart;
        Alder = alder;
        Studietype = studietype;
    }
}