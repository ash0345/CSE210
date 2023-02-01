using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square square = new Square("Blue", 4);
        Rectangle rectangle = new Rectangle("Red", 3, 5);
        Circle circle = new Circle("Pink", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color:{color}\nArea:{area}\n");
        }
    }
}