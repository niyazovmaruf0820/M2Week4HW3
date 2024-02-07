
using task2;

Location location1 = new Location(10, 20);

Location location2 = new Location(-10, 40);

Rectangle rectangle = new Rectangle(5,10, location1);
rectangle.SetColor("red");
System.Console.WriteLine("Side1: " + rectangle.GetSide1());
System.Console.WriteLine("Side2: " + rectangle.GetSide2());
System.Console.WriteLine("Area: " + rectangle.Area());
System.Console.WriteLine("Perimeter: " + rectangle.Perimeter());
System.Console.WriteLine("Coordinate_x: " + rectangle.GetCoordinates().x);
System.Console.WriteLine("Coordinate_y: " + rectangle.GetCoordinates().y);
System.Console.WriteLine(rectangle.ToString());
System.Console.WriteLine("----------------------------------------");


Circle circle = new Circle(10, location2);
circle.SetColor("green");
System.Console.WriteLine("Radius: " + circle.GetRadius());
System.Console.WriteLine("Area: " + circle.Area());
System.Console.WriteLine("Perimeter: " + circle.Perimeter());
System.Console.WriteLine("Coordinate_x: " + circle.GetCoordinates().x);
System.Console.WriteLine("Coordinate_y: " + circle.GetCoordinates().y);
System.Console.WriteLine(circle.ToString());

