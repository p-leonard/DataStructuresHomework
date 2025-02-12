// Written By: Patrick Leonard
// 2/2/25

namespace Page_75___Repairing_The_Clocktower
{
    public class Program
    {
        static void Main()
        {
            // Gather user input.
            Console.WriteLine("Enter an integer.");
            string? userNum = Console.ReadLine();
            
            // Try to parse an int from our input.
            if(!int.TryParse(userNum, out int parsedUserNum))
            {
                throw new ArgumentException();
            }

            // Output Tick or Tock.
            Console.Write(Clocktower.TickOrTock(parsedUserNum));
        }
    }
}
