namespace Øvelse3._0;

public class Rectangle :Shapes
{
    private double length;
    private double width;

    public Rectangle(double x, double y, double length, double width) : base(x, y)
    {
    
        Length = length;
        Width = width;
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public override double Area()
    {
        return length * width;
    }
}