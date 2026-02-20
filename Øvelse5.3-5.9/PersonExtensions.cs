namespace Øvelse5._3;

public static class PersonExtensions
{
    public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
    {
        foreach (var p in lst)
        {
            if (pred(p))
            {
                p.Accepted = true;
            }
        }
    }

    public static void Reset(this List<Person> lst)
    {
        foreach (var p in lst)
        {
            p.Accepted = false;
        }
    }
}