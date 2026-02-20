namespace Øvelse5._3;

public class SortByAge : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Age -  y.Age;
    }
}