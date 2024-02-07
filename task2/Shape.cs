namespace task2;

public abstract class Shape
{
    protected string color;
    public void SetColor(string color)
    {
        this.color = color;
    }
    protected Location c;
    public Shape(Location c)
    {
        this.c = c;
    }
    public Location GetCoordinates()
    {
        return c;
    }
    public override string ToString()
    {
        return $"Color: {color}";
    }
    public abstract double Area();
    public abstract double Perimeter();
}
