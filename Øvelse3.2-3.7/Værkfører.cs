namespace Øvelse3._2_3._7;

public class Værkfører : Mekaniker
{
    public int ÅrstalVærkfører { get; set; }
    public int Tillæg { get; set; }
    public Værkfører(CprNr cpr, string navn, Adresse adresse, string medarbejdernummer, int årstalSvendeprøve, int timeløn, int årstalVærkfører, int tillæg) : base(cpr, navn, adresse, medarbejdernummer, årstalSvendeprøve, timeløn)
    {
        ÅrstalVærkfører = årstalVærkfører;
        Tillæg = tillæg;
    }

    public override double BeregnUgeLøn()
    {
        return base.BeregnUgeLøn() + Tillæg;
    }

}