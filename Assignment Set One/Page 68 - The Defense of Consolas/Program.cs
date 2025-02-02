// Written By: Patrick Leonard
// 2/1/25

namespace Page_68___The_Defense_of_Consolas
{
    public class Program
    {
        static void Main()
        {
            // Gather our inputs.
            Console.WriteLine("Please enter a row:");
            string? userRow = Console.ReadLine();

            Console.WriteLine("Please enter a column:");
            string? userCol = Console.ReadLine();

            // Parse usable ints from our input
            if (!int.TryParse(userCol, out int parsedCol))
            {
                throw new ArgumentException(nameof(userCol), "Could not parse value.");
            }

            if (!int.TryParse(userRow, out int parsedRow))
            {
                throw new ArgumentException(nameof(userCol), "Could not parse value.");
            }

            // Instantiate our DefenseCalculator
            DefenseCalculator defenseCalculator = new(parsedRow, parsedCol);

            // Print our calculated result!
            Console.WriteLine(defenseCalculator);

        }
    }
}
