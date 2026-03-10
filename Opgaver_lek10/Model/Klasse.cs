namespace Opgaver_lek10.Model;

public class Klasse
{
    public int KlasseId { get; set; }
    public string KlasseName { get; set; }
    public List<Elev> Elever { get; } = new List<Elev>();
    public List<Lærer> Lærere { get; } = new List<Lærer>();

    public Klasse(string klasseName)
    {
        KlasseName = klasseName;
    }

    public Klasse (){}
    
    public void addElev(Elev elev)
    {
        Elever.Add(elev);
        elev.setKlasse(this);
    }
    
    public void addLærer(Lærer lærer)
    {
        Lærere.Add(lærer);
        lærer.addKlasse(this);
    }

    public override string ToString()
    {
        return KlasseName;
    }
}