namespace Øvelse3._0;

public abstract class Shapes
{
    private double x, y;
    
    public Shapes() : this(1,1)
    {
    }

    public Shapes(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public abstract double Area();
}