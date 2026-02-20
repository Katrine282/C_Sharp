namespace Øvelse3._2_3._7;

public abstract class Medarbejder : IharAdresse
{
    private const int _timerPrUge = 37;
    public string Navn { get; set; }
    public Adresse Adresse { get; set; }
    public CprNr Cpr { get; }
    public string Medarbejdernummer { get; set; }

    public Medarbejder(CprNr cpr, string navn, Adresse adresse, string medarbejdernummer)
    {
        Navn = navn;
        Adresse = adresse;
        Cpr = cpr;
        Medarbejdernummer = medarbejdernummer;
    }

    public abstract double BeregnUgeLøn();
       
    public int TimerPrUge //og den tilhørende access metode, bemærk readOnly, dvs get!
    {
        get { return _timerPrUge; }
    }

    public override string ToString()
    {
        return "Med Nr: " + Medarbejdernummer +
               "\nCPR: " + Cpr + "\nNavn: " + Navn + 
               "\nAdresse: " + Adresse;
    }
}