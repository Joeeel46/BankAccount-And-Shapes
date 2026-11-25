public class Rectangle : IShape
{
    public string Name { get; } = "Rectangle";
    public double Height { get; } 
    public double Width { get; }

    public Rectangle(double height, double width)
    {
        if(height <= 0 || width <= 0)
        {
            throw new ArgumentException("Width and Height should be greater than zero");
        }

        Height = height;
        Width = width;
    }

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }

    public override string ToString()
    {
        return $"{Name} Width = {Width} Height = {Height} Area = {Area():F2} Perimeter = {Perimeter():F2}";
    }
}