namespace Øvelse3._0;

public class Circle : Shapes
{
    private double radius;

    public Circle(double x, double y, double radius) : base(x, y)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override double Area()
    {
        return radius * radius * Math.PI;
    }
}