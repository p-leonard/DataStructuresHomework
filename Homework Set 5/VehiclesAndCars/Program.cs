// Written By: Patrick Leonard
// 2/26/25

namespace VehiclesAndCars;

public class Program
{
    static void Main(string[] args)
    {
        Car myActualTerribleCar = new("Ford", "Focus", 2004, 4); // It's like a really really ugly beige.
        Motorcycle instanceOfMotorcycle = new("Harley Davidson", "Electra Glide", 1976, false);

        Console.WriteLine(myActualTerribleCar);
        Console.WriteLine(instanceOfMotorcycle);
    }
}

public abstract class Vehicle
{
    // Backing Fields
    private string make = "n/a";
    private string model = "n/a";
    private int year = -1;

    // Gets and Sets
    public string Make
    {
        get => make;
        set => make = value;
    }
    public string Model
    {
        get => model;
        set => model = value;
    }
    public int Year
    {
        get => year;
        set => year = value;
    }

    // Constructors
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public Vehicle() : this("n/a", "n/a", -1) { }

    // Methods
    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

public class Car : Vehicle
{
    // Backing Fields
    private int numberOfDoors = -1;

    // Gets and Sets
    public int NumberOfDoors
    {
        get => numberOfDoors;
        set => numberOfDoors = value;
    }

    // Constructors
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Methods
    public override string ToString()
    {
        return base.ToString() + $" with {NumberOfDoors} doors";
    }
}

public class Motorcycle : Vehicle
{
    // Backing Fields
    private bool? hasSidecar = null;

    // Gets and Sets
    public bool HasSidecar
    {
        get => hasSidecar ?? throw new NullReferenceException();
        set => hasSidecar = value;
    }

    // Constructors
    public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    // Methods
    public override string ToString()
    {
        return base.ToString() + $" (has sidecar: {HasSidecar})";
    }
}