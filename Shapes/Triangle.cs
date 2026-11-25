public class Triangle : IShape
{
    public string Name { get; } = "Triangle";
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if(sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides of Triangle cannot be zero.");
        }

        if(sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
        {
            throw new ArgumentException("Theses sides cannot form a Triangle.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double Perimeter()
    {
        return SideA + SideB + SideC;
    }

    public double Area()
    {
        double s = (SideA + SideB + SideC)/2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override string ToString()
    {
        return $"{Name} with sides = {SideA} {SideB} {SideC} Area = {Area():F2} Perimeter = {Perimeter():F2}";
    }
}