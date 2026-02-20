namespace Øvelse3._2_3._7;

public class Mekaniker :Medarbejder
{
    public int ÅrstalSvendeprøve { get; set; }
    public int Timeløn { get; set; }

    public Mekaniker(CprNr cpr, string navn, Adresse adresse, string medarbejdernummer, int årstalSvendeprøve, int timeløn) : base(cpr, navn, adresse, medarbejdernummer)
    {
        ÅrstalSvendeprøve = årstalSvendeprøve;
        Timeløn = timeløn;
    }

    public override double BeregnUgeLøn()
    {
        return Timeløn * TimerPrUge;
    }
}