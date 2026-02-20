// See https://aka.ms/new-console-template for more information

using Øvelse4._2;

PowerPlant pp = new PowerPlant();
pp.SetWarning(warningToConsole);
pp.SetWarning(jubiiToConsole);
pp.HeatUp();

static void warningToConsole()
{
    Console.WriteLine("ADVARSEL!!!!!!!!");
}

static void jubiiToConsole()
{
    Console.WriteLine("Jubii!!!!!!!!");
}


public delegate void Warning();