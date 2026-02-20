// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//øvelse 3
Console.WriteLine("Skriv det antal fib tal du vil have");
int antal = int.Parse(Console.ReadLine());

while(antal != 0)
{
    Fibonacci(antal);
    Console.WriteLine("\nSkriv det antal fib tal du vil have");
    antal = int.Parse(Console.ReadLine());
}

static void Fibonacci(int antal)
{
    int sidsteTal = 0;
    int tal = 1;
    Console.Write($"{sidsteTal}, {tal}, ");
    for (int i = 0; i < antal - 2; i++)
    {
        int udskriv = tal + sidsteTal;
        Console.Write(udskriv + ", ");
        sidsteTal = tal;
        tal = udskriv;
    }
}

//øvelse 4
Console.WriteLine("Skriv det år du er født");
int år = int.Parse(Console.ReadLine());

int resulktat;
CalculateAge(new DateTime(år, 6, 5), out resulktat);
Console.WriteLine(resulktat);

static void CalculateAge(DateTime BirthDateInput, out int age)
{
    var fødselsår = BirthDateInput.Year;
    age = DateTime.Now.Year - fødselsår;
}

//øvelse 5
MyNormalMethod();
static void MyMethodWithError(int num = 0)
{
    throw new Exception("fejl");
}

static void MyNormalMethod(int num = 0)
{
    try
    {
        Console.WriteLine("kalder metode");
        MyMethodWithError();
    }
    catch (Exception e)
    {
        Console.WriteLine("håndterer fejl");
        Console.WriteLine(e.ToString());
    }
    finally
    {
        Console.WriteLine("kører finally");
    }
}