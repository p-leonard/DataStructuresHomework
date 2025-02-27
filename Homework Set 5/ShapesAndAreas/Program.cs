// Written By: Patrick Leonard
// 2/26/25

using System;

namespace ShapesAndAreas;

public class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new("Red", 56, 12);
        Circle circ = new("Blue", 12.5);

        Console.WriteLine(rect);
        Console.WriteLine(circ);
    }
}

public abstract class Shape
{
    // Backing Fields
    private string color = "none";

    // Gets and Sets
    public string Color
    {
        get => color;
        set => color = value;
    }
    public double Area
    {
        get => GetArea();
    }

    // Constructors
    public Shape(string color) => Color = color;

    // Methods
    protected abstract double GetArea();

    public override string ToString() => $"{Color} {this.GetType().Name} Area: {Area}";
}

public class Circle : Shape
{
    // Backing Fields
    private double radius = -1;

    // Gets and Sets
    public double Radius
    {
        get => radius;
        set => radius = value;
    }

    // Constructors
    public Circle(string color, double radius) : base(color) => Radius = radius;

    // Methods
    protected override double GetArea()=> Math.PI * Radius * Radius;

    public override string ToString() => base.ToString() + $" Radius: {Radius}";
}

public class Rectangle : Shape
{
    // Backing Fields
    private double width = -1;
    private double height = -1;

    // Gets and Sets
    public double Width
    {
        get => width;
        set => width = value;
    }
    public double Height
    {
        get => height;
        set => height = value;
    }

    // Constructors
    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    // Methods
    protected override double GetArea() => Width * Height;

    public override string ToString() => base.ToString() + $" Width: {Width}, Height: {Height}"; 

}
