// Written By: Patrick Leonard
// 2/6/25

using System;

namespace The_Prototype
{
    public class Prototype
    {
        // Backing Fields
        private int pilot_num = 0;

        // Methods
        public void QueryUserForPilotNumber()
        {
            int userNum = QueryInt("Pilot, enter a number between 1 and 100. ");
            if (!(userNum >= 0 && userNum <= 100)) throw new ArgumentException();
            pilot_num = userNum;
        }

        public void StartHunterGame()
        {
            while (true)
            {
                int hunterGuess = QueryInt("Hunter, enter a number between 1 and 100. ");
                
                if (hunterGuess == pilot_num)
                {
                    Console.WriteLine("You Guessed the Number!");
                    break;
                }
                else if (hunterGuess > pilot_num)
                {
                    Console.WriteLine("Your guess was too high.");
                }
                else
                {
                    Console.WriteLine("Your guess was too low.");
                }
            }
        }

        public static int QueryInt(string prompt="Enter an int: ")
        {
            Console.WriteLine(prompt);
            string? userChoice = Console.ReadLine();

            if (!int.TryParse(userChoice, out int userInt)) throw new ArgumentException();

            return userInt;
        }




    }
}
