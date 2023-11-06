using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square sq1 = new Square("Blue", 5);
        shapes.Add(sq1);

        Rectangle rec1 = new Rectangle("Red", 4, 7);
        shapes.Add(rec1);

        Circle circle1 = new Circle("Yellow", 8);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}