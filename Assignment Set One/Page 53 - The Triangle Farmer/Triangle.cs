// Written By: Patrick Leonard
// 1/30/29

public class Triangle
{
	// Backing Fields
	private double measureBase;
	private double measureHeight;

	// Properties
	// Base is the measure of one leg of a Triangle.
	public double Base
	{
		get => measureBase;
		set => measureBase = value < 0 ? 0 : value;
	}

	// Height is the measure of a line drawn perpendicular to the the Base
	// of the Triangle
	public double Height
	{
		get => measureHeight;
		set => measureHeight = value < 0 ? 0 : value;
	}

	// Calculates the area of the triangle.
	public double Area
	{
		get => (0.5) * Base * Height;
	}

	// Constructors
	public Triangle(double aBase, double aHeight){
		Base = aBase;
		Height = aHeight;
	}

    // Methods
    public override string ToString()
    {
		return $"""
			Triangle:
			  Base: {Base}
			  Height: {Height}
			  Area: {Area}
""";
    }
}
