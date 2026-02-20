namespace Øvelse4._6;

public class ByWeightSorter : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Weight -  y.Weight;
    }
}