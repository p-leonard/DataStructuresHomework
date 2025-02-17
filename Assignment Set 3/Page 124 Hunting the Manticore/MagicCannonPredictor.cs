// Written By: Patrick Leonard
// 2/6/25

namespace Page_124_Hunting_the_Manticore
{
    public static class MagicCannonPredictor
    {

        public static void PrintPredictions(int iterations = 100)
        {
            for (int i = 1; i <= iterations; i++)
            {
                bool isFire, isElectric;
                isFire = i % 3 == 0;
                isElectric = i % 5 == 0;

                if (isFire && isElectric)
                {
                    Console.Write($"{i}. ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Electric and Fire");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (isFire)
                {
                    Console.Write($"{i}. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (isElectric)
                {
                    Console.Write($"{i}. ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine($"{i}. Normal");
                }
            }
        }

        public static int PredictDamageFromRoundNum(int roundNum)
        {
            bool isFire, isElectric;
            isFire = roundNum % 3 == 0;
            isElectric = roundNum % 5 == 0;

            if (isFire && isElectric)
            {
                return 10;
            }
            else if (isFire || isElectric)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
    }
}

