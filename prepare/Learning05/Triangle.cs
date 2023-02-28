public class Triangle : Shape
{
    private double _base; 
    private double _height; 
    private double _half; 
    public Triangle(string name, string color, double Base, double height, double half) 
    : base(name, color)
    {
        _base = Base;
        _height = height;
        _half = half;
    }

    public override double GetArea()
    {
        return _half * _base * _height;
    }


}