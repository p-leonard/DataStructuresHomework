// Written By: Patrick Leonard
// 1/30/29

namespace Page_53___The_Triangle_Farmer
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Gather user inputs.
            // What is the user's desired length?
            Console.WriteLine("Please enter the length of the base of your Triangle.");
            string? userBase = Console.ReadLine();

            // What is the user's desired height?
            Console.WriteLine("Please enter the height of your Triangle.");
            string? userHeight = Console.ReadLine();

            // Let's convert the user's input to a usable number.
            double parsedBase, parsedHeight;
            if (!double.TryParse(userBase, out parsedBase))
            {
                Console.WriteLine("Your base could not be parsed. Please try again.");
                throw new ArgumentException();
            }
            else if (!double.TryParse(userHeight, out parsedHeight))
            {
                Console.WriteLine("Your height could not be parsed. Please try again.");
                throw new ArgumentException();
            }

            // Instantiate our Triangle Object
            Triangle triangle = new(parsedBase, parsedHeight);

            // Spit out our result!
            Console.WriteLine(triangle);
        }
    }
}
