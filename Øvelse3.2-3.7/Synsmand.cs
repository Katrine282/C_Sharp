namespace Øvelse3._2_3._7;

public class Synsmand : Mekaniker
{
    public int AntalSyn { get; set; }
    public Synsmand(CprNr cpr, string navn, Adresse adresse, string medarbejdernummer, int timeløn, int årstalSvendeprøve, int antalSyn) : base(cpr, navn, adresse, medarbejdernummer, årstalSvendeprøve, timeløn)
    {
        AntalSyn = antalSyn;
    }

    public override double BeregnUgeLøn()
    {
        return AntalSyn * 290;
    }
}