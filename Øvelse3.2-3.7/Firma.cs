namespace Øvelse3._2_3._7;

public class Firma : IharAdresse
{
    public Adresse Adresse { get; set; }
    public string Navn { get; set; }

    public Firma(Adresse adresse, string navn)
    {
        Adresse = adresse;
        Navn = navn;
    }
}