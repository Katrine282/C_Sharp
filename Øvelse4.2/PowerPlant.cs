namespace Øvelse4._2;

public class PowerPlant
{
    private Warning warning;
    
    public PowerPlant()
    {
    }

    public void SetWarning(Warning wa)
    {
        this.warning += wa;
    }

    public void HeatUp()
    {
        Random rnd = new Random();
        int tal = rnd.Next(0, 101);
        Console.WriteLine(tal);
        if (tal > 50)
        {
            this.warning.Invoke();
        }
    }
    
}