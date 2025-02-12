using System.ComponentModel;
using System.Reflection.Metadata;

namespace TheWatchtower
{
    internal class Program
    {
        static void Main()
        {

            List<string> myList = new() {"foo", "bar", "ding", "dong" };

            Console.WriteLine("Enter an X coordinate. (int)");
            string? strXPos = Console.ReadLine();

            Console.WriteLine("Enter a Y coordinate. (int)");
            string? strYPos = Console.ReadLine();

            if (!int.TryParse(strXPos, out int xPos)) throw new ArgumentException();
            if (!int.TryParse(strYPos, out int yPos)) throw new ArgumentException();

            Console.WriteLine(Watchtower.PosToString(xPos, yPos));
        }
    }
}
