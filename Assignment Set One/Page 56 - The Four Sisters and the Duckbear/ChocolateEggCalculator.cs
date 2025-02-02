// Written By: Patrick Leonard
// 1/30/2025

namespace Page56_TheFourSistersAndTheDuckbear;

public class ChocolateEggCalculator
{
    //Backing Fields
    private int numberOfSisters;
    private int numberOfChocolates;

    //Properties, Gets and Sets
    public int NumberOfSisters
    {
        get => numberOfSisters;
        set
        {
            if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value), "NumberOfSisters cannot be less than or equal to Zero.");
            numberOfSisters = value;
        }
    }
    public int NumberOfChocolates
    {
        get => numberOfChocolates;
        set
        {
            if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value), "NumberOfChocolates cannot be less than or equal to Zero.");
            numberOfChocolates = value;
        }
    }
    public int ChocolatesPerSister
    {
        get => NumberOfChocolates / NumberOfSisters;
    }
    public int ChocolatesForDuckbear
    {
        get => NumberOfChocolates % NumberOfSisters;
    }

    //Constructors
    public ChocolateEggCalculator(int numberOfSisters, int numberOfChocolates) 
    {
        NumberOfSisters    = numberOfSisters;
        NumberOfChocolates = numberOfChocolates;
    }
    public ChocolateEggCalculator(int numberOfChocolates):this(4, numberOfChocolates) { }

    //Methods
    public override string ToString()
    {
        return $"""
            Chocolate Egg Calculator
              Properties:
                Number of Chocolates: {NumberOfChocolates}
                Number of Sisters: {NumberOfSisters}
              Calculated Values:
                Chocolates Per Sister: {ChocolatesPerSister}
                Chocolates for Duckbear: {ChocolatesForDuckbear}
            """;
    }
}
