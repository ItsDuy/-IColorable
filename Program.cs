namespace IColorable;
public interface IGeometricObject
{
    double GetArea();
}

public class Circle : IGeometricObject
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : IGeometricObject
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }
}
public class Square : IGeometricObject, IColorables
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetArea()
    {
        return side * side;
    }

    public void HowToColor()
    {
        Console.WriteLine("Color all four sides.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IGeometricObject[] shapes = new IGeometricObject[]
      {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(3)
      };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
            if (shape is IColorables colorableShape)
            {
                colorableShape.HowToColor();
            }
        }
    }
}
