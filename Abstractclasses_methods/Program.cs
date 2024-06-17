 using System;

public abstract class Shape
{

    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth {  get; set;
}
    public Rectangle (double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea()
    {
        return Length = Breadth;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape firstCircle = new Circle(5);
        Shape firstRectangle = new Rectangle(4, 6);

        Console.WriteLine("Area of circle : " + firstCircle.GetArea());
        Console.WriteLine("Area of Rectangle : " + firstRectangle.GetArea());}
}