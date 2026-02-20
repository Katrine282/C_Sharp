namespace Øvelse3._2_3._7;

public class MedarbejderListe<T>
{
    private readonly Dictionary<T, Medarbejder> _collection = new Dictionary<T, Medarbejder>();
    
    public void AddElement(T key, Medarbejder p)
    {
        _collection.Add(key, p);
    }

    public Medarbejder GetElement(T key)
    {
        return _collection[key];
    }

    public int Size()
    {
        return _collection.Count;
    }
}