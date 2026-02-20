// See https://aka.ms/new-console-template for more information

using Øvelse4._6;

Person p1 = new Person("Line", 43, 80);
Person p2 = new Person("William", 20, 110);
Person p3 = new Person("Åge", 90, 85);
Person p4 = new Person("Anna", 11, 60);
Person p5 = new Person("Rasmus", 60, 90);

List<Person> personer = new List<Person>();
personer.Add(p1);
personer.Add(p2);
personer.Add(p3);
personer.Add(p4);
personer.Add(p5);

personer.Sort(new ByNameSorter());
Console.WriteLine("Navn: ");
foreach (var person in personer)
{
    Console.WriteLine(person);  
}

/** personer.Sort((a, b) => a.Name.CompareTo(b.Name));
Console.WriteLine("Navn: ");
foreach (var person in personer)
{
    Console.WriteLine(person);
} **/


personer.Sort(new ByAgeSorter());
Console.WriteLine("\nAlder:");
foreach (var person in personer)
{
    Console.WriteLine(person);  
}

personer.Sort(new ByWeightSorter());
Console.WriteLine("\nVægt: ");
foreach (var person in personer)
{
    Console.WriteLine(person);  
}
