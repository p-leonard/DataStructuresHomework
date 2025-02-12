// Written By: Patrick Leonard
// 2/1/25

namespace Page56_TheFourSistersAndTheDuckbear
{
    public class Program
    {
        static void Main()
        {
            // Gather user inputs
            // How many chocolate eggs are there?
            Console.WriteLine("How many chocolate eggs are there?");
            string? numChocolates = Console.ReadLine();

            // Let's make sure that the user provided something we can parse into an integer.
            int parsedNumChocolates;
            if(!int.TryParse(numChocolates, out parsedNumChocolates))
            {
                Console.WriteLine("Your input couldn't be parsed into an integer. Please re-launch.");
            }

            // Instantiate an instance of our calculator and spit out our calculated values!
            Console.WriteLine(new ChocolateEggCalculator(parsedNumChocolates));
        }
    }
}

