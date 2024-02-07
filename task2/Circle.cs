namespace task2;

public class Circle : Shape
{
    protected double radius;
    public Circle(int radius, Location c) : base(c)
    {
        this.radius = radius;
    }
    public void SetRadius(int radius)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public override double Area()
    {
        return 3.14 * radius * radius;   
    }

    public override double Perimeter()
    {
        return 2 * 3.14 * radius;
    }
    public override string ToString()
    {
        return  $"{base.ToString()}\nRadius: {radius}";
    }
}
