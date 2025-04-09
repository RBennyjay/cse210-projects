using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Square
        // Square square = new Square("Red", 5.0);

        // Call GetColor and GetArea methods
        // Console.WriteLine($"Color of the square: {square.GetColor()}");
        // Console.WriteLine($"Area of the square: {square.GetArea()}");

        // Square
        // Square square = new Square("Red", 5.0);
        // Console.WriteLine($"[Square] Color: {square.GetColor()}, Area: {square.GetArea()}");

        // Rectangle
        // Rectangle rectangle = new Rectangle("Blue", 4.0, 6.0);
        // Console.WriteLine($"[Rectangle] Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        // Circle
        // Circle circle = new Circle("Green", 3.0);
        // Console.WriteLine($"[Circle] Color: {circle.GetColor()}, Area: {circle.GetArea():F2}");



        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add a Square, Rectangle, and Circle
        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 4.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        // Iterate through the list and display each shape's color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}