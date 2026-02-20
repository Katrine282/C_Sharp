using Øvelse3._0;

List<Shapes> figurer = new();
figurer.Add(new Circle(3, 4, 7));
figurer.Add(new Circle(4, 7, 20));
figurer.Add(new Rectangle(8, 1, 5, 5));
figurer.Add(new Rectangle(6, 5, 8 ,3));

foreach (var item in figurer)
{
    Console.WriteLine(item.X + ", " + item.Y);
    Console.WriteLine("Areal: " + item.Area());
    Console.WriteLine(0);
}