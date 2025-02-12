// Written By: Patrick Leonard
// 2/6/25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magic_Cannon
{
    public static class MagicCannonPredictor
    {
        public static void PrintPredictions(int iterations = 100)
        {
            for(int i = 1; i <= iterations; i++)
            {
                bool isFire, isElectric;
                isFire = i % 3 == 0;
                isElectric = i % 5 == 0;

                if(isFire && isElectric)
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
    }
}
