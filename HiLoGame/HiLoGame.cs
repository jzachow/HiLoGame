using System;
using System.Collections.Generic;
using System.Text;

namespace HiLoGame
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber;
        private static int pot = 10;

        public static int GetPot()
        {
            return pot;
        }

        public static void Guess(bool higher)
        {
            int newNumber = random.Next(1, MAXIMUM + 1);

            if (higher && (newNumber >= currentNumber) || (!higher && (newNumber <= currentNumber)))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }

            currentNumber = newNumber;
            Console.WriteLine($"The current number is: {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"The number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The number is at most {half}");
            }            
            pot--;
        }
    }
}
