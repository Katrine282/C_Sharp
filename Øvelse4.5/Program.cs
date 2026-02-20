// See https://aka.ms/new-console-template for more information

using Øvelse4._5;

Kortspil spil = new Kortspil();
spil.AddKort(Kulør.Klør, Nummer.Dame);
spil.AddKort(Kulør.Hjerter, Nummer.Es);
spil.AddKort(Kulør.Spar, Nummer.Ti);
spil.AddKort(Kulør.Ruder, Nummer.Konge);
spil.AddKort(Kulør.Klør, Nummer.Fem);
spil.AddKort(Kulør.Hjerter, Nummer.To);
spil.AddKort(Kulør.Spar, Nummer.Ni);
spil.AddKort(Kulør.Ruder, Nummer.Knægt);
spil.AddKort(Kulør.Klør, Nummer.Otte);
spil.AddKort(Kulør.Hjerter, Nummer.Seks);
spil.AddKort(Kulør.Spar, Nummer.Dame);
spil.AddKort(Kulør.Ruder, Nummer.Fire);
spil.AddKort(Kulør.Klør, Nummer.Konge);
spil.AddKort(Kulør.Hjerter, Nummer.Syv);
spil.AddKort(Kulør.Spar, Nummer.Tre);


var billedKort = spil.filterCardGame(FilterByBilledkort);
Console.WriteLine("Billed kort");
foreach (Kort kort in billedKort)
{
    Console.WriteLine(kort.ToString());
}

var ikkeBilledKort = spil.filterCardGame(FilterByIkkeBilledkort);
Console.WriteLine("\nIkke billed kort");
foreach (Kort kort in ikkeBilledKort)
{
    Console.WriteLine(kort.ToString());
}
var klør = spil.filterCardGame(FilterByKlør);
Console.WriteLine("\nKlør");
foreach (Kort kort in klør)
{
    Console.WriteLine(kort.ToString());
}

var lamba = spil.filterCardGame(k => k.Kulør == Kulør.Spar || k.Kulør == Kulør.Klør);
Console.WriteLine("\nSorte kort");
foreach (Kort kort in lamba)
{
    Console.WriteLine(kort.ToString());
}


static bool FilterByKlør(Kort kort)
{
    return kort.Kulør == Kulør.Klør;
}

static bool FilterByBilledkort(Kort kort)
{
    if (kort.Nummer == Nummer.Dame || kort.Nummer == Nummer.Konge || kort.Nummer == Nummer.Knægt)
    {
        return true;
    }
    else
    {
        return false;
    }
}


static bool FilterByIkkeBilledkort(Kort kort)
{
    if (kort.Nummer == Nummer.Dame || kort.Nummer == Nummer.Konge || kort.Nummer == Nummer.Knægt)
    {
        return false;
    }
    else
    {
        return true;
    }
}
