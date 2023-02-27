public abstract class Shape
{
    private string _name;
    private string _color;

    public Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }
    public string GetNameAndColor()
    {
        return $"{_name} is {_color}";
    }

    public abstract double GetArea();
}