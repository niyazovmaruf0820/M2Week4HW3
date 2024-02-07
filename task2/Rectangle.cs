namespace task2;

public class Rectangle : Shape
{
    protected double side1;
    protected double side2;
    public Rectangle(double side1, double side2, Location c) : base(c)
    {
        this.side2 = side2;
        this.side1 = side1;
    }
    public void SetSide1AndSide2(int side1, int side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public double GetSide1()
    {
        return side1;
    }
    public double GetSide2()
    {
        return side2;
    }
    
    public override double Area()
    {
        return side1 * side2;
    }

    public override double Perimeter()
    {
        return 2 * (side1 + side2);
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nSide1: {side1}\nSide2: {side2}";
    }
}
