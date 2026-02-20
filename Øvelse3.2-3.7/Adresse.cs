namespace Øvelse3._2_3._7;

public class Adresse
{
    public Adresse(string vejnavn, int vejNr)
    {
        Vejnavn = vejnavn;
        VejNr = vejNr;
    }

    public string Vejnavn { get; set; }
    public int VejNr { get; set; }

    public override string ToString()
    {
        return Vejnavn + " " + VejNr;
    }
}