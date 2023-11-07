using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 4, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 6);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }
    }
}