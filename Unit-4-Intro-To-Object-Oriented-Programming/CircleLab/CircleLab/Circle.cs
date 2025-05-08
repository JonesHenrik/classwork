namespace CircleLab;

public class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public double CalclateDiameter()
    {
        return radius * 2;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
    
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public void Grow()
    {
        radius = radius * 2;
        Console.WriteLine("The circle is magically growing.");
    }

    public double GetRadius()
    {
        return radius;
    }
}