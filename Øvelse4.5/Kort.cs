namespace Øvelse4._5;

public delegate bool FilterCardDelegate(Kort kort);
public class Kort
{
    
    public Kort(Kulør kulør,  Nummer nummer)
    {
        Nummer = nummer;
        Kulør = kulør;
    }

    public Nummer Nummer { get; set; }
    public Kulør Kulør { get; set; }
    
    

    public override string ToString()
    {
        return Kulør + " " + Nummer;
    }
}