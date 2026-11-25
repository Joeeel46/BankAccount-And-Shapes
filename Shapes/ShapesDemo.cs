public class ShapesDemo
{
    public static void Run()
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(7),
            new Rectangle(3,6),
            new Triangle(3,6,8),
            new Triangle(4,4,4),
            new Square(3),
            new Square(9)
        };

        Console.WriteLine("\n===== ALL SHAPES =====");

        foreach(IShape shape in shapes)
        {
            Console.WriteLine(shape);
        }

        Console.WriteLine("\n==== Sorted By Area ====");

        var sortedShapes = shapes.OrderBy(shape => shape.Area());

        foreach(IShape shape in sortedShapes)
        {
            Console.WriteLine(shape);
        }

        Console.WriteLine("\n==== Largest Shape ====");

        var LargestShape = shapes.OrderByDescending(shape => shape.Area()).First();

        Console.WriteLine(LargestShape);

        double TotalArea = shapes.Sum(shape => shape.Area());

        Console.WriteLine($"\nTotal Area of Shapes: {TotalArea:F2}");

        Console.WriteLine("\n==== Invalid Shape Test ====");

        try
        {
            Circle InvalidCircle = new Circle(-10);
        }catch(ArgumentException ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }
    }
}