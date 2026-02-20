namespace Øvelse4._6;

public class ByNameSorter: IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Name.CompareTo(y.Name);
    }
}