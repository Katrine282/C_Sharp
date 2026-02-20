namespace MyLibary;

public class MyList
{
    private List<int> items = new List<int>();
    public MyList() 
    { 
        for (int i = 0; i < 10; i++)
        {
            items.Add(RandomNumber());
        }
    }

    private int RandomNumber()
    {
        Random rand = new Random();
        return rand.Next(1, 101);
    }

    public void AddNumber(int item)
    {
        items.Add(item);
    }
    public void PrintNumbers()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }  
}