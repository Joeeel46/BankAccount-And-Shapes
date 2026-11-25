

public class Square : Rectangle
{
    public string Name { get; } = "Square";

    public double Side { get; }

    public Square(double side): base(side, side)
    {
        Side = side;
    }

    public override string ToString()
    {
        return $"{Name} with side = {Side} Area = {Area()} Parameter = {Perimeter()}";
    }
}