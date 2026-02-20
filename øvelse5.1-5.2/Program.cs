
List<int> tal = new List<int> { 7, 2, 15, 9, 1, 20, 3, 12, 6, 18 };

//Lav en søgning på alle lige ints 
tal.ForEach(i =>
{
    if (i % 2 == 0) Console.WriteLine(i);
});

//Lav en søgning efter det sidste tal over 15 (så du skal nok have mindst et over 15)
Console.WriteLine("sidste tal over 15: " + tal.FindLast( i => i > 15));

//Lav en søgning efter index på det sidste tal over 15
Console.WriteLine("index for dette tal: " + tal.FindLastIndex( i => i > 15));

//øvelse 5.2
//alle lige ints
IEnumerable<int> result = tal.Where(i => i % 2 == 0).OrderBy(i => i);
Console.WriteLine("Query Methods");
foreach (var i in result)
{
    Console.WriteLine(i);
}

//alle ints med to sifte
result = tal.Where(i => i % 2 == 0 && i.ToString().Length == 2).OrderBy(i => i);
Console.WriteLine();
foreach (var i in result)
{
    Console.WriteLine(i);
}

Console.WriteLine("Query Expression");
//alle lige ints
result = from i in tal
    where i % 2 == 0 
    orderby i
    select i;
foreach (var i in result)
{
    Console.WriteLine(i);
}

//alle ints med to sifte
result = from i in tal
    where i % 2 == 0 && i.ToString().Length == 2
    orderby i
    select i;
Console.WriteLine("2 ciffer");
foreach (var i in result)
{
    Console.WriteLine(i);
}

// Console.WriteLine("Som metode");
// ligeLinq(tal);
// lige2CiffreLinq(tal);


static void ligeLinq(List<int> tal)
{
    IEnumerable<int> result = tal.Where(i => i % 2 == 0).OrderBy(i => i);
    Console.WriteLine("Lige tal:");
    foreach (var i in result)
    {
        Console.WriteLine(i);
    }
}

static void lige2CiffreLinq(List<int> tal)
{
    IEnumerable<int> result = tal.Where(i => i % 2 == 0 && i.ToString().Length == 2).OrderBy(i => i);
    Console.WriteLine("lige tal med 2 ciffere:");
    foreach (var i in result)
    {
        Console.WriteLine(i);
    }
}