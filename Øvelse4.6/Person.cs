namespace Øvelse4._6;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public Person(string name, int age, int weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override string ToString()
    {
        return "Navn:" + Name + " År:" + Age + " Vægt:" + Weight;
    }
}