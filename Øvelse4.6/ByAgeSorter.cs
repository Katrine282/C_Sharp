namespace Øvelse4._6;

public class ByAgeSorter : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Age -  y.Age;
    }
}