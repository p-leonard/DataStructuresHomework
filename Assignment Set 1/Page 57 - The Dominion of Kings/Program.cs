// Written by: Patrick Leonard
// 2/1/25

namespace Page_57___TheDominionOfKings
{
    public class Program
    {
        static void Main()
        {
            // Let's shake it up a little. Let's instantiate our KingdomAnalyzer first.
            KingdomAnalyzer analyzer = new(); // Our chained constructors allow this!

            // Gather user inputs.
            Console.WriteLine("How many estates do we have?");
            string? userNumEstates = Console.ReadLine();

            Console.WriteLine("How many Duchies do we have?");
            string? userNumDuchies = Console.ReadLine();

            Console.WriteLine("How many Provinces do we have?");
            string? userNumProvinces = Console.ReadLine();

            // Parse our inputs into integers.
            if (!int.TryParse(userNumEstates, out int numEstates))
            {
                throw new ArgumentException(nameof(numEstates), "Could not parse value.");
            } 
            
            if (!int.TryParse(userNumDuchies, out int numDuchies))
            {
                throw new ArgumentException(nameof(numDuchies), "Could not parse value.");
            } 
            
            if (!int.TryParse(userNumProvinces, out int numProvinces))
            {
                throw new ArgumentException(nameof(numProvinces), "Could not parse value.");
            }

            // Populate our KingdomAnalyzer object:
            analyzer.NumberOfEstates   = numEstates;
            analyzer.NumberOfDuchies   = numDuchies;
            analyzer.NumberOfProvinces = numProvinces;

            // Finally, print out our results.
            Console.WriteLine(analyzer);
        }
    }
}
