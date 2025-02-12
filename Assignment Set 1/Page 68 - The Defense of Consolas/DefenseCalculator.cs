// Written By: Patrick Leonard
// 2/1/25

namespace Page_68___The_Defense_of_Consolas;

public class DefenseCalculator
{
    // Note: This object assumes rows and columns are indexed from one, where (1,1) is in the bottom left corner.

    // Constants
    private const int SIZE = 8; // How large is the grid we're using?


    // Backing Fields
    private int row;
    private int column;


    // Gets and Sets
    public int Row
    {
        get => row;
        set => row = AssertValidCoordinate(value);
    }

    public int Column
    {
        get => column;
        set => column = AssertValidCoordinate(value);
    }


    // Calculated Properties
    public (int, int) NorthPosition
    {
        get => (Row + 1, Column);
    }
    public (int, int) SouthPosition
    {
        get => (Row - 1, Column);
    }
    public (int, int) EastPosition
    {
        get => (Row, Column + 1);
    }
    public (int, int) WestPosition
    {
        get => (Row, Column - 1);
    }


    // Constructors
    public DefenseCalculator(int row, int column)
    {
        Row = row;
        Column = column;
    }


    // Methods
    public override string ToString()
    {
        return $"""
            Defense Calculator:
            Center Point: ({Row}, {Column})
            Deploy to:
             {NorthPosition}
             {SouthPosition}
             {EastPosition}
             {WestPosition}
            """;
    }

    private static int AssertValidCoordinate(int num)
    {
        // If the provided coordinate would place one of our people off of the grid, throw an exception.
        if (!(num >= 2 && num <= SIZE - 1)) throw new ArgumentOutOfRangeException(nameof(num),"Invalid Coordinate");
        return num;
    }
}
