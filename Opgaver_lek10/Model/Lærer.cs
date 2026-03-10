namespace Opgaver_lek10.Model;

public class Lærer
{
    public int LærerID { get; set; }
    public string Navn { get; set; }
    public List<Klasse> Klasser { get; } = new List<Klasse>();

    public Lærer(string navn)
    {
        Navn = navn;
    }
    
    public Lærer()
    {}

    public void addKlasse(Klasse klasse)
    {
        Klasser.Add(klasse);
        klasse.addLærer(this);
    }
}