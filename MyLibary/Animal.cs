namespace MyLibary;

public class Animal : IAnimal
{
    private string species;

    public Animal(string species)
    {
        Species = species;
    }

    public string Species
    {
        get { return species; }
        set { species = value; }
    }

    public bool IsDog()
    {
        if (Species.ToLower() == "dog")
        {
            return true;
        }
        return false;
    }
}