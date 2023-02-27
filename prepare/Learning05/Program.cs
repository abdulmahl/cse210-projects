using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("square", "red", 7);

        Circle circle = new Circle("circle", "blue", 13);
        
        Rectangle rectangle = new Rectangle("rectangle", "green", 7, 11);
        
        // GetShapeInformation(square);
        // GetShapeInformation(circle);
        // GetShapeInformation(rectangle);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            shape.GetNameAndColor();
            shape.GetArea();

            WriteLine($"The {shape.GetNameAndColor()},");
            WriteLine($"with the area of {shape.GetArea()}\n");
        }
    }

    // public static void GetShapeInformation(Shape shape)
    // {
    //     WriteLine($"The {shape.GetNameAndColor()}.");
    //     WriteLine($"The area is {shape.GetArea()}\n");
    // }
}