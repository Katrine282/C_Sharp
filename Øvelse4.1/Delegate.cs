namespace Øvelse4._1;

public class Delegate
{
    public static void CalculateAndDisplay(int a, int b, Operation operation)
    {
        Console.WriteLine("a: " + a +  ", b: " + b );
        var op = operation(a, b);
        Console.WriteLine("Result: " + op.ToString());
    }
}