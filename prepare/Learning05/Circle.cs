public class Circle : Shape
{
    private int _radius;
    public Circle(string name, string color, int radius) 
    : base(name, color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        var area = Math.PI * Math.Pow(_radius, 2);
        return Math.Round(area, 2);
    }

}