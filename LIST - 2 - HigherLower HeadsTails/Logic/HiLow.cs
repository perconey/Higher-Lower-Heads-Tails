using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___2___HigherLower_HeadsTails.Logic
{
    class HiLow
    {
        private static int _number;

        public static int Number
        {
            set => _number = value;
            get => _number;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return random.Next(min, max);
            }
        }

        public HiLow()
        {
            ChooseNumberToGuess();
        }
        public bool CheckGuess(int guess)
        {
            if (guess == Number)
            {
                Console.WriteLine("You've guessed the right number!");
                return true;
            }
            if(guess < Number)
            {
                Console.WriteLine("Too low");
                return false;
            }
            if(guess > Number)
            {
                Console.WriteLine("Too high");
                return false;
            }
            return false;
        }

        public void ChooseNumberToGuess()
        {
            Number = RandomNumber(0, 10000);
        }

    }
}
