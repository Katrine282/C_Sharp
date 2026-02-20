// See https://aka.ms/new-console-template for more information

Console.WriteLine(Factorial(4));
Console.WriteLine(4.Factorial());

Console.WriteLine(Power(4, 2));
Console.WriteLine(4.Power(2));


static int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    return n * Factorial(n - 1);
}

static int Power(int n, int p)
{
    return (int) Math.Pow(n, p);
}



public static class Extension
{
    public static int Factorial(this int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    public static int Power(this int n, int p)
    {
        return (int) Math.Pow(n, p);
    }
    
}