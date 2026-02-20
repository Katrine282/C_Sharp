using Delegate = Øvelse4._1.Delegate;

Delegate.CalculateAndDisplay(4, 5, Add);
Delegate.CalculateAndDisplay(4, 5, Multiply);


static int Add(int a, int b)
{
    return a + b;
}

static int Multiply(int a, int b)
{
    return a * b;
}

public delegate int Operation(int a, int b);