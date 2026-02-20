
using System.Runtime.InteropServices.ComTypes;
using Øvelse5._3;

List<Person> people1 = Exercise1();
// people1.ForEach(p => Console.WriteLine(p));
IEnumerable<Person> result = new List<Person>();

//----------------------------------------------------------------------------------
//Øvelse 5.3
//Alle personer med en score under 2
// result = people1.FindAll(p => p.Score < 2);
// foreach (var p in result)
// {
//     Console.WriteLine(p.Name +  " " + p.Score);
// }

//Alle personer med en lige score
// result = people1.FindAll(p => p.Score % 2 == 0);
// foreach (var p in result)
// {
//     Console.WriteLine(p.Name +  " " + p.Score);
// }

//Alle personer med en lige score og weight større end 60
// result = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
// foreach (var p in result)
// {
//     Console.WriteLine(p.Name +  " " + p.Score + " Vægt: " +  p.Weight);
// }

//Alle personer med en vægt deleligt med 3
// result = people1.FindAll(p => p.Weight % 3 == 0);
// foreach (var p in result)
// {
//     Console.WriteLine(p.Name +  " " + p.Weight);
// }

//----------------------------------------------------------------------------------
//Øvelse 5.4 
int index = -1;

//finde index på den første person med en score på præcis 3
// index = people1.FindIndex(p => p.Score == 3);
// Console.WriteLine($"{people1[index].Name}  {people1[index].Score}");

// index på den første person under 10 år, som har en score på 3
// index = people1.FindIndex(p => p.Score == 3 && p.Age < 10);
// Console.WriteLine($"{people1[index].Name}  {people1[index].Score}  {people1[index].Age}");

//Hvor mange personer er der under 10 år som har en score på 3?
// result = people1.FindAll(p => p.Age < 10 &&  p.Score == 3);
// Console.WriteLine(result.Count());

// Brug FindIndex til at finde index på den første personer under 8 år, med en score på 3
// index = people1.FindIndex(p => p.Score == 3 && p.Age < 8);
// Console.WriteLine($"{people1[index].Name}  {people1[index].Score}");

//----------------------------------------------------------------------------------
//Øvelse 5.5 - sortering
// people1.Sort(new SortByAge());
// people1.ForEach(p => Console.WriteLine(p.Name + " " + p.Age));

//----------------------------------------------------------------------------------
//Øvelse 5.6
// people1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
// people1.ForEach(p => Console.WriteLine($"{p.Score} {p.Age} {p.Accepted}"));

//----------------------------------------------------------------------------------
//Øvelse 5.7
// result = people1.OrderByDescending(p => p.Score).ToList();
// foreach (var p in result)
// {
//     Console.WriteLine(p.Name +  " " + p.Score);
// }

// result = from p in people1
//     orderby p.Age descending 
//     select p;
// foreach (var p in result)
// {
//     Console.WriteLine(p.Name +  " " + p.Age);
// }

//----------------------------------------------------------------------------------
//Øvelse 5.9
people1.Reset();
people1.ForEach(p => Console.WriteLine($"{p.Score} {p.Age} {p.Accepted}"));


static List<Person> Exercise1()
{
    try
    {
        List<Person> people = Person.ReadCSVFile(@"C:\Users\Katri\OneDrive - EFIF\4. Semester\CSharp\data1.csv");
        return people;
    }
    catch (Exception ex)
    {
        Console.WriteLine("EXCEPTION: " + ex.Message);
        Console.WriteLine("You should probably set the filename to the " +
                          "Person.ReadCSVFile method to something on your disk!");
    }
    return null;
}