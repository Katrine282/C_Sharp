namespace Øvelse4._5;

public class Kortspil
{
    private List<Kort> Kortene = new List<Kort>();

    public void AddKort(Kulør kulør, Nummer nummer)
    {
        Kortene.Add(new Kort(kulør, nummer));
    }

    public List<Kort> filterCardGame(FilterCardDelegate filter)
    {
        List<Kort> result = new List<Kort>();
        
        foreach (var kort in Kortene)
        {
            if (filter(kort))
            {
                result.Add(kort);
            }
        }
        return result;
    }
}