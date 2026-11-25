public class Circle : IShape
{
    public string Name { get; } = "Circle";
    public double Radius { get; }

    public Circle(double radius){

        if(radius <= 0)
        {
            throw new ArgumentException("Radius cannot be zero or below zero.");
        }

        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return $"{Name} Radius = {Radius}, Area = {Area():F2}, Perimeter = {Perimeter():F2}";
    }
}