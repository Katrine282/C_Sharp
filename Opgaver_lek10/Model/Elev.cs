namespace Opgaver_lek10.Model;

public class Elev
{
    public int ElevID { get; set; }
    public string Navn { get; set; }
    public string CPR { get; set; }
    public string Adresse { get; set; }
    public Klasse? klasse { get; set; }
    public int? klasseId { get; set; }

    public Elev(string navn, string cpr,  string adresse)
    {
        Navn = navn;
        CPR = cpr;
        Adresse = adresse;
    }

    public Elev()
    {
    }

    public void setKlasse(Klasse klasse)
    {
        this.klasse = klasse;
        klasseId = klasse.KlasseId;
    }

    public override string ToString()
    {
        return ElevID + " " + Navn + " går i " + klasse;
    }
}